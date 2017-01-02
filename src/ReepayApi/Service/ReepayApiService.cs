using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using log4net;
using ReepayApi.Api;
using ReepayApi.Client;
using ReepayApi.Model;

namespace ReepayApi.Service
{

    #region ReepayService Interface

    #endregion

    public class ReepayApiService : IReepayApiService
    {
        private readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private const int MaxNoOfRetries = 3;
        private readonly string _reepayPrivatApikey;
        private readonly string _reepayUrl;
        private readonly string _userAgent = "Winefamily/" + Assembly.GetCallingAssembly().GetName().Name;
        private readonly bool _reepayTestFlag;

        public ReepayApiService(string reepayPrivatApikey, string reepayUrl)
        {
            this._reepayPrivatApikey = reepayPrivatApikey;
            this._reepayUrl = reepayUrl;
            this._reepayTestFlag = false;
        }

        public ReepayApiService(string reepayPrivatApikey, string reepayUrl, bool reepayTestFlag)
        {
            this._reepayPrivatApikey = reepayPrivatApikey;
            this._reepayUrl = reepayUrl;
            this._reepayTestFlag = reepayTestFlag;
        }

        public Tuple<bool, string> UpdatePaymentMethod(int siteUserGuid, string reepayCardToken)
        {
            var reepayPlans = this.GetPlans(true);

            if (reepayPlans.StatusCode != (int)HttpStatusCode.OK || reepayPlans.Data == null || reepayPlans.Data.Count == 0)
            {
                return new Tuple<bool, string>(false, $"Internal server error. Error code: '{reepayPlans.StatusCode}' from remote system");
            }

            var subs = this.GetSubscriptions(siteUserGuid, Subscription.StateEnum.Active);
            foreach (var s in subs.Data.Content)
            {
                RemoveAllPaymentMethods(s.Handle);
            }

            if (string.IsNullOrEmpty(reepayCardToken))
            {
                return new Tuple<bool, string>(false, "invalid carddata");
            }

            if (subs.Data.Content.Any())
            {
                var setCardReponse = SetCardPaymentMethod(subs.Data.Content[0].Handle, reepayCardToken);
                if (setCardReponse.StatusCode != (int)HttpStatusCode.OK)
                {
                    return new Tuple<bool, string>(false, $"Internal server error. Error code: '{setCardReponse.StatusCode}' from remote system");
                }
            }

            return new Tuple<bool, string>(true, "OK");
        }

        /// <summary>
        /// Create customer and subscribtion 
        /// </summary>
        /// <param name="subscription">subscrription data to create</param>
        /// <returns>subscription data</returns>
        public ApiResponse<Subscription> CreateSubscription(CreateSubscription subscription)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new SubscriptionApi(config);

            if (string.IsNullOrEmpty(subscription.CardToken))
            {
                subscription.CardToken = null;
            }

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.CreateSubscriptionJsonWithHttpInfo(subscription);
                    if (res.StatusCode != (int)HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Subscription>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Subscription>((int)HttpStatusCode.InternalServerError, null, null);
        }


        /// <summary>
        /// Create subscribtion for customer
        /// if no card id specfied then an email will be sent to user to add payment
        /// </summary>
        /// <param name="customerHandle">customer id</param>
        /// <param name="planHandle">plan id</param>
        /// <param name="cardToken">cardtoken</param>
        /// <param name="couponCodes">Coupon codes</param>
        /// <returns>subscription data</returns>
        public ApiResponse<Subscription> CreateSubscription(string customerHandle, string planHandle, string cardToken, List<string> couponCodes)
        {
            const bool generateSubshandle = true;
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new SubscriptionApi(config);
            var signupMethod = string.IsNullOrEmpty(cardToken) ? "email" : "card_token";

            var subscription = new CreateSubscription(customerHandle, planHandle, null, null, this._reepayTestFlag, null, null, signupMethod, null, null, null, null, generateSubshandle, null, null,
                null, cardToken, null, null, couponCodes);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.CreateSubscriptionJsonWithHttpInfo(subscription);
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Subscription>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Subscription>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// validate coupon code
        /// </summary>
        /// <param name="customerHandle">customer id</param>
        /// <param name="planHandle">plan id</param>
        /// <param name="couponCode">Coupon code</param>
        /// <returns>subscription data</returns>
        public ApiResponse<Coupon> ValidateCouponCode(string customerHandle, string planHandle, string couponCode)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new CouponApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.ValidateCodeWithHttpInfo(couponCode, planHandle, customerHandle);
                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Coupon>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Coupon>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Reactivate cancelled subscription
        /// </summary>
        /// <param name="handle">subscription handle</param>
        /// <returns>statuscode and subscription</returns>
        public ApiResponse<Subscription> ReactivateCancelledSubscription(string handle)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new SubscriptionApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.UncancelWithHttpInfo(handle);
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Subscription>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Subscription>((int) HttpStatusCode.InternalServerError, null, null);
        }


        /// <summary>
        /// Cancel all subscriptions for subscriber
        /// </summary>
        /// <param name="siteUserGuid">siteuserGuid</param>
        /// <returns>statuscode and list of cancelled subscriptions</returns>
        public ApiResponse<List<Subscription>> CancelSubscriptions(int siteUserGuid)
        {
            var cancelledSubscriptions = new List<Subscription>();
            var statusCode = (int) HttpStatusCode.OK;
            var apiSearchResponse = this.GetSubscriptions(siteUserGuid, Subscription.StateEnum.Active);

            if (apiSearchResponse.StatusCode != (int) HttpStatusCode.OK || !apiSearchResponse.Data.Content.Any())
            {
                return new ApiResponse<List<Subscription>>(apiSearchResponse.StatusCode, null, cancelledSubscriptions);
            }

            foreach (var subscription in apiSearchResponse.Data.Content)
            {
                if (subscription.IsCancelled.HasValue && subscription.IsCancelled.Value)
                {
                    cancelledSubscriptions.Add(subscription);
                }
                else
                {
                    var apiResponse = this.CancelSubscribtion(subscription);
                    if (apiSearchResponse.StatusCode == (int) HttpStatusCode.OK)
                    {
                        cancelledSubscriptions.Add(apiResponse.Data);
                    }
                    else
                    {
                        statusCode = apiSearchResponse.StatusCode;
                    }
                }
            }

            return new ApiResponse<List<Subscription>>(statusCode, null, cancelledSubscriptions);
        }

        /// <summary>
        /// Cancel subscription
        /// </summary>
        /// <param name="subscription">subscription to cancel</param>
        /// <returns>statuscode and subscription data</returns>
        public ApiResponse<Subscription> CancelSubscribtion(Subscription subscription)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new SubscriptionApi(config);

            if (subscription.IsCancelled.HasValue && subscription.IsCancelled.Value)
            {
                // Subscription already cancelled
                return new ApiResponse<Subscription>((int) HttpStatusCode.OK, null, subscription);
            }

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.CancelSubscriptionWithHttpInfo(subscription.Handle);
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }
                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Subscription>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Subscription>((int) HttpStatusCode.InternalServerError, null, subscription);
        }

        /// <summary>
        /// Get subscribtions for customer
        /// </summary>
        /// <param name="siteUserGuid">siteuserguid</param>
        /// <param name="state">subscription state search creteria</param>
        /// <returns>statuscode and subscriptions</returns>
        public ApiResponse<SubscriptionSearch> GetSubscriptions(int siteUserGuid, Subscription.StateEnum? state)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new SubscriptionApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.GetSubscriptionsWithHttpInfo(null, null, $"customer.handle:{siteUserGuid}");
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    if (state != null)
                    {
                        for (int n = res.Data.Content.Count - 1; n >= 0; n--)
                        {
                            if (res.Data.Content[n].State != state.Value)
                            {
                                res.Data.Content.RemoveAt(n);
                            }
                        }
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<SubscriptionSearch>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<SubscriptionSearch>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Get cardgateway agreement
        /// </summary>
        /// <param name="activeonly">active agreements only</param>
        /// <returns>statuscode and gateway agreements</returns>
        public ApiResponse<List<CardGatewayAgreement>> CardGatewayAgreement(bool? activeonly)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new AgreementApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.GetCardGatewayAgreementsWithHttpInfo(activeonly);
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<List<CardGatewayAgreement>>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<List<CardGatewayAgreement>>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Check if customer has active subscription
        /// </summary>
        /// <param name="siteUserGuid">siteuserGuid</param>
        /// <returns>true, if customer has an active subscription</returns>
        public bool HasActiveSubscription(int siteUserGuid)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new CustomerApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.GetCustomerWithHttpInfo(siteUserGuid.ToString());
                    return res.Data.ActiveSubscriptions > 0;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return false;
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return false;
        }


        /// <summary>
        /// Remove all payment methods from subscription 
        /// </summary>
        /// <param name="subscriptionHandle">subscription handle</param>
        /// <returns>statuscode and PaymentMethods</returns>
        public ApiResponse<PaymentMethods> RemoveAllPaymentMethods(string subscriptionHandle)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new SubscriptionApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.RemoveAllPaymentMethodsWithHttpInfo(subscriptionHandle);
                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<PaymentMethods>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<PaymentMethods>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Deactive all payment methods except 
        /// </summary>
        /// <param name="siteUserGuid">Siteuserguid</param>
        /// <param name="card">card that should NOT be deactiacted</param>
        /// <returns>statuscode and carddata</returns>
        public ApiResponse<PaymentMethods> DeactivatePaymentMethodsCustomerExcept(int siteUserGuid, Card card)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;

            try
            {
                var paymentMethods = this.GetPaymentMethods(siteUserGuid);
                if (paymentMethods.Data == null)
                {
                    return new ApiResponse<PaymentMethods>((int) HttpStatusCode.OK, null, null);
                }

                for (var i = paymentMethods.Data.Cards.Count - 1; i >= 0; --i)
                {
                    if (card != null && paymentMethods.Data.Cards[i].Id != card.Id)
                    {
                        this.DeactivatePaymentMethodCustomer(siteUserGuid, paymentMethods.Data.Cards[i]);
                    }
                    else
                    {
                        paymentMethods.Data.Cards.RemoveAt(i);
                    }
                }

                return paymentMethods;
            }
            catch (ApiException apiException)
            {
                this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                return new ApiResponse<PaymentMethods>(apiException.ErrorCode, null, null);
            }
        }

        /// <summary>
        /// Deactivate payment method
        /// </summary>
        /// <param name="siteUserGuid">Siteuserguid</param>
        /// <param name="card">card to deactivate</param>
        /// <returns>statuscode and carddata</returns>
        public ApiResponse<PaymentMethods> DeactivatePaymentMethodCustomer(int siteUserGuid, Card card)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new CustomerApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.InactivatePaymentMethodWithHttpInfo(siteUserGuid.ToString(), card.Id);
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<PaymentMethods>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<PaymentMethods>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Add payment method to customer
        /// </summary>
        /// <param name="siteUserGuid">Siteuserguid</param>
        /// <param name="cardtoken">cardtoken from reepay</param>
        /// <returns>statuscode and carddata</returns>
        public ApiResponse<Card> AddPaymentMethodToCustomer(int siteUserGuid, string cardtoken)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new CustomerApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var body = new CardToken(cardtoken);
                    var res = api.AddCardJsonWithHttpInfo(siteUserGuid.ToString(), body);
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Card>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Card>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Get payment for customer 
        /// </summary>
        /// <param name="siteUserGuid">siteuserGuid</param>
        /// <returns>statuscode and Customer data</returns>
        public ApiResponse<PaymentMethods> GetPaymentMethods(int siteUserGuid)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new CustomerApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.GetCustomerPaymentMethodsWithHttpInfo(siteUserGuid.ToString());
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<PaymentMethods>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<PaymentMethods>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Get customer data
        /// </summary>
        /// <param name="siteUserGuid">siteuserGuid</param>
        /// <returns>statuscode and Customer data</returns>
        public ApiResponse<Customer> GetCustomer(int siteUserGuid)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new CustomerApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.GetCustomerWithHttpInfo(siteUserGuid.ToString());
                    if (res.StatusCode != (int) HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Customer>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Customer>((int) HttpStatusCode.InternalServerError, null, null);
        }

        public ApiResponse<Customer> UpdateCustomer(int siteuserGuid, string email, string name)
        {
            var customer = this.GetCustomer(siteuserGuid);

            if (customer.StatusCode != (int) HttpStatusCode.OK)
            {
                return customer;
            }

            customer.Data.Email = email;
            customer.Data.FirstName = name;

            var res = this.UpdateCustomer(customer.Data.Handle, customer.Data.Email, customer.Data.FirstName, customer.Data.LastName, customer.Data.Address, customer.Data.Address2, customer.Data.City,
                customer.Data.PostalCode, customer.Data.Country, customer.Data.Phone, customer.Data.Company, customer.Data.Vat);

            return res;
        }

        /// <summary>
        /// Update customer data
        /// </summary>
        /// <param name="handle">Customer id, blank for auto generate</param>
        /// <param name="email"> customer email</param>
        /// <param name="firstName">custoemer firstname</param>
        /// <param name="lastname">customer last name</param>
        /// <param name="address">customer address</param>
        /// <param name="address2">customer address2</param>
        /// <param name="city">customer city</param>
        /// <param name="postalCode">customer postal code</param>
        /// <param name="country">customer country</param>
        /// <param name="phone">customer phone</param>
        /// <param name="company">customer company</param>
        /// <param name="vat">customer vat</param>
        /// <returns>statuscode and customer data</returns>
        public ApiResponse<Customer> UpdateCustomer(string handle, string email, string firstName, string lastname, string address, string address2, string city,
            string postalCode, string country, string phone, string company, string vat)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new CustomerApi(config);
            var customer = new UpdateCustomer(email, address, address2, city, country, phone, company, vat, firstName, lastname, postalCode);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var apiResponse = api.UpdateCustomerJsonWithHttpInfo(handle, customer);
                    return apiResponse;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Customer>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Customer>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Create customer in ReePay
        /// </summary>
        /// <param name="handle">Customer id, blank for auto generate</param>
        /// <param name="email"> customer email</param>
        /// <param name="firstName">custoemer firstname</param>
        /// <param name="lastname">customer last name</param>
        /// <param name="address">customer address</param>
        /// <param name="address2">customer address2</param>
        /// <param name="city">customer city</param>
        /// <param name="postalCode">customer postal code</param>
        /// <param name="country">customer country</param>
        /// <param name="phone">customer phone</param>
        /// <param name="company">customer company</param>
        /// <param name="vat">customer vat</param>
        /// <returns>statuscode and customer data</returns>
        public ApiResponse<Customer> CreateCustomer(string handle, string email, string firstName, string lastname, string address, string address2, string city,
            string postalCode, string country, string phone, string company, string vat)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var generateHandle = string.IsNullOrEmpty(handle);
            var config = this.GetDefaultApiConfiguration();
            var api = new CustomerApi(config);
            var newCustomer = new CreateCustomer(email, address, address2, city, country, phone, company, vat, handle, this._reepayTestFlag, firstName, lastname, postalCode, generateHandle);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var apiResponse = api.CreateCustomerJsonWithHttpInfo(newCustomer);
                    return apiResponse;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Customer>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Customer>((int) HttpStatusCode.InternalServerError, null, null);
        }

        /// <summary>
        /// Gets plans from Reepay
        /// </summary>
        /// <param name="onlyActive">only active plans</param>
        /// <returns>statuscode and list ofplans</returns>
        public ApiResponse<List<Plan>> GetPlans(bool onlyActive)
        {
            var config = this.GetDefaultApiConfiguration();
            var api = new PlanApi(config);
            var myClassname = MethodBase.GetCurrentMethod().Name;

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var apiResponse = api.GetPlansListWithHttpInfo(onlyActive);
                    return apiResponse;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<List<Plan>>(apiException.ErrorCode, null, null);
                    ;
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<List<Plan>>((int) HttpStatusCode.InternalServerError, null, null);
        }

        public ApiResponse<object> GetAuthentificationVerify()
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new AuthenticateApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var apiResponse = api.VerifyAuthenticationWithHttpInfo();
                    return apiResponse;
                    ;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{MethodBase.GetCurrentMethod().Name} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<object>(apiException.ErrorCode, null, null);
                    ;
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<object>((int) HttpStatusCode.InternalServerError, null, null);
        }

        public Configuration GetDefaultApiConfiguration()
        {
            var encodedApiKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(this._reepayPrivatApikey + ":"));
            var apiClient = new ApiClient(this._reepayUrl);

            var defaultHeader = new Dictionary<string, string>();
            string username = null;
            string password = null;
            string accessToken = null;
            var apiKey = new Dictionary<string, string>();
            var apiKeyPrefix = new Dictionary<string, string>();
            string tempFolderPath = null;
            string dateTimeFormat = null;
            var timeout = 100000;

            apiKey.Add("ApiKey", encodedApiKey);
            apiKeyPrefix.Add("ApiKey", "Basic");

            var config = new Configuration(apiClient, defaultHeader, username, password, accessToken, apiKey, apiKeyPrefix, tempFolderPath, dateTimeFormat, timeout, this._userAgent);
            config.AddDefaultHeader("Authorization", config.GetApiKeyWithPrefix("ApiKey"));
            return config;
        }

        /// <summary>
        /// Get discount data
        /// </summary>
        /// <param name="handle">handle</param>
        /// <returns>statuscode and Discount data</returns>
        public ApiResponse<Discount> GetDiscount(string handle)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new DiscountApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.GetDiscountWithHttpInfo(handle);
                    if (res.StatusCode != (int)HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<Discount>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<Discount>((int)HttpStatusCode.InternalServerError, null, null);
        }

        public ApiResponse<PaymentMethods> SetCardPaymentMethod(string subscriptionHandle, string cardToken)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new SubscriptionApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var cardBody = new SetCardPaymentMethod {CardToken = cardToken};
                    var res = api.SetCardPaymentMethodJsonWithHttpInfo(subscriptionHandle, cardBody);
                    if (res.StatusCode != (int)HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<PaymentMethods>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<PaymentMethods>((int)HttpStatusCode.InternalServerError, null, null);
        }

        public ApiResponse<PaymentMethods> GetSubscriptionPaymentMethods(string subscriptionHandle)
        {
            var myClassname = MethodBase.GetCurrentMethod().Name;
            var config = this.GetDefaultApiConfiguration();
            var api = new SubscriptionApi(config);

            for (var i = 0; i <= MaxNoOfRetries; i++)
            {
                try
                {
                    var res = api.GetSubscriptionPaymentMethodsWithHttpInfo(subscriptionHandle);
                    if (res.StatusCode != (int)HttpStatusCode.OK)
                    {
                        this._log.Error($"Unexpected answer from reepay. {myClassname} Errorcode {res.StatusCode}");
                    }

                    return res;
                }
                catch (ApiException apiException)
                {
                    this._log.Error($"{myClassname} {apiException.ErrorCode} {apiException.ErrorContent}");
                    return new ApiResponse<PaymentMethods>(apiException.ErrorCode, null, null);
                }
                catch (Exception) when (i < MaxNoOfRetries)
                {
                    this._log.Debug($"{myClassname} retry attempt {i}");
                }
            }

            return new ApiResponse<PaymentMethods>((int)HttpStatusCode.InternalServerError, null, null);
        }
    }
}