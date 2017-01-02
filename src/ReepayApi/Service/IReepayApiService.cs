using System;
using System.Collections.Generic;
using ReepayApi.Client;
using ReepayApi.Model;

namespace ReepayApi.Service
{
    public interface IReepayApiService
    {
        Tuple<bool, string> UpdatePaymentMethod(int siteUserGuid, string reepayCardToken);

        /// <summary>
        /// Create customer and subscribtion 
        /// </summary>
        /// <param name="subscription">subscrription data to create</param>
        /// <returns>subscription data</returns>
        ApiResponse<Subscription> CreateSubscription(CreateSubscription subscription);

        /// <summary>
        /// Create subscribtion for customer
        /// if no card id specfied then an email will be sent to user to add payment
        /// </summary>
        /// <param name="customerHandle">customer id</param>
        /// <param name="planHandle">plan id</param>
        /// <param name="cardToken">cardtoken</param>
        /// <param name="couponCodes">Coupon codes</param>
        /// <returns>subscription data</returns>
        ApiResponse<Subscription> CreateSubscription(string customerHandle, string planHandle, string cardToken, List<string> couponCodes);

        /// <summary>
        /// validate coupon code
        /// </summary>
        /// <param name="customerHandle">customer id</param>
        /// <param name="planHandle">plan id</param>
        /// <param name="couponCode">Coupon code</param>
        /// <returns>subscription data</returns>
        ApiResponse<Coupon> ValidateCouponCode(string customerHandle, string planHandle, string couponCode);

        /// <summary>
        /// Reactivate cancelled subscription
        /// </summary>
        /// <param name="handle">subscription handle</param>
        /// <returns>statuscode and subscription</returns>
        ApiResponse<Subscription> ReactivateCancelledSubscription(string handle);

        /// <summary>
        /// Cancel all subscriptions for subscriber
        /// </summary>
        /// <param name="siteUserGuid">siteuserGuid</param>
        /// <returns>statuscode and list of cancelled subscriptions</returns>
        ApiResponse<List<Subscription>> CancelSubscriptions(int siteUserGuid);

        /// <summary>
        /// Cancel subscription
        /// </summary>
        /// <param name="subscription">subscription to cancel</param>
        /// <returns>statuscode and subscription data</returns>
        ApiResponse<Subscription> CancelSubscribtion(Subscription subscription);

        /// <summary>
        /// Get subscribtions for customer
        /// </summary>
        /// <param name="siteUserGuid">siteuserguid</param>
        /// <param name="state">subscription state search creteria</param>
        /// <returns>statuscode and subscriptions</returns>
        ApiResponse<SubscriptionSearch> GetSubscriptions(int siteUserGuid, Subscription.StateEnum? state);

        /// <summary>
        /// Get cardgateway agreement
        /// </summary>
        /// <param name="activeonly">active agreements only</param>
        /// <returns>statuscode and gateway agreements</returns>
        ApiResponse<List<CardGatewayAgreement>> CardGatewayAgreement(bool? activeonly);

        /// <summary>
        /// Check if customer has active subscription
        /// </summary>
        /// <param name="siteUserGuid">siteuserGuid</param>
        /// <returns>true, if customer has an active subscription</returns>
        bool HasActiveSubscription(int siteUserGuid);

        /// <summary>
        /// Remove all payment methods from subscription 
        /// </summary>
        /// <param name="subscriptionHandle">subscription handle</param>
        /// <returns>statuscode and PaymentMethods</returns>
        ApiResponse<PaymentMethods> RemoveAllPaymentMethods(string subscriptionHandle);

        /// <summary>
        /// Deactive all payment methods except 
        /// </summary>
        /// <param name="siteUserGuid">Siteuserguid</param>
        /// <param name="card">card that should NOT be deactiacted</param>
        /// <returns>statuscode and carddata</returns>
        ApiResponse<PaymentMethods> DeactivatePaymentMethodsCustomerExcept(int siteUserGuid, Card card);

        /// <summary>
        /// Deactivate payment method
        /// </summary>
        /// <param name="siteUserGuid">Siteuserguid</param>
        /// <param name="card">card to deactivate</param>
        /// <returns>statuscode and carddata</returns>
        ApiResponse<PaymentMethods> DeactivatePaymentMethodCustomer(int siteUserGuid, Card card);

        /// <summary>
        /// Add payment method to customer
        /// </summary>
        /// <param name="siteUserGuid">Siteuserguid</param>
        /// <param name="cardtoken">cardtoken from reepay</param>
        /// <returns>statuscode and carddata</returns>
        ApiResponse<Card> AddPaymentMethodToCustomer(int siteUserGuid, string cardtoken);

        /// <summary>
        /// Get payment for customer 
        /// </summary>
        /// <param name="siteUserGuid">siteuserGuid</param>
        /// <returns>statuscode and Customer data</returns>
        ApiResponse<PaymentMethods> GetPaymentMethods(int siteUserGuid);

        /// <summary>
        /// Get customer data
        /// </summary>
        /// <param name="siteUserGuid">siteuserGuid</param>
        /// <returns>statuscode and Customer data</returns>
        ApiResponse<Customer> GetCustomer(int siteUserGuid);

        ApiResponse<Customer> UpdateCustomer(int siteuserGuid, string email, string name);

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
        ApiResponse<Customer> UpdateCustomer(string handle, string email, string firstName, string lastname, string address, string address2, string city,
            string postalCode, string country, string phone, string company, string vat);

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
        ApiResponse<Customer> CreateCustomer(string handle, string email, string firstName, string lastname, string address, string address2, string city,
            string postalCode, string country, string phone, string company, string vat);

        /// <summary>
        /// Gets plans from Reepay
        /// </summary>
        /// <param name="onlyActive">only active plans</param>
        /// <returns>statuscode and list ofplans</returns>
        ApiResponse<List<Plan>> GetPlans(bool onlyActive);

        ApiResponse<object> GetAuthentificationVerify();
        Configuration GetDefaultApiConfiguration();

        /// <summary>
        /// Get discount data
        /// </summary>
        /// <param name="handle">handle</param>
        /// <returns>statuscode and Discount data</returns>
        ApiResponse<Discount> GetDiscount(string handle);

        ApiResponse<PaymentMethods> SetCardPaymentMethod(string subscriptionHandle, string cardToken);
        ApiResponse<PaymentMethods> GetSubscriptionPaymentMethods(string subscriptionHandle);
    }
}