# IO.Swagger.Api.SubscriptionApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelChangePlan**](SubscriptionApi.md#cancelchangeplan) | **POST** /v1/subscription/{handle}/cancel_change_plan | Cancel pending plan change
[**CancelSubscription**](SubscriptionApi.md#cancelsubscription) | **POST** /v1/subscription/{handle}/cancel | Cancel subscription
[**ChangeNextPeriodStartJson**](SubscriptionApi.md#changenextperiodstartjson) | **POST** /v1/subscription/{handle}/change_next_period_start | Change next renewal date
[**ChangePlanJson**](SubscriptionApi.md#changeplanjson) | **POST** /v1/subscription/{handle}/change_plan | Change plan
[**CreateSubscriptionDiscount**](SubscriptionApi.md#createsubscriptiondiscount) | **POST** /v1/subscription/{handle}/discount | Add subscription discount
[**CreateSubscriptionInvoice**](SubscriptionApi.md#createsubscriptioninvoice) | **POST** /v1/subscription/{handle}/invoice | Create invoice ondemand for subscription
[**CreateSubscriptionJson**](SubscriptionApi.md#createsubscriptionjson) | **POST** /v1/subscription | Create subscription
[**DeleteSubscriptionDiscount**](SubscriptionApi.md#deletesubscriptiondiscount) | **DELETE** /v1/subscription/{handle}/discount/{sdHandle} | Delete subscription discount
[**Expire**](SubscriptionApi.md#expire) | **POST** /v1/subscription/{handle}/expire | Expire subscription
[**GetSubscription**](SubscriptionApi.md#getsubscription) | **GET** /v1/subscription/{handle} | Get subscription
[**GetSubscriptionDiscount**](SubscriptionApi.md#getsubscriptiondiscount) | **GET** /v1/subscription/{handle}/discount/{sdHandle} | Get subscription discount
[**GetSubscriptionDiscounts**](SubscriptionApi.md#getsubscriptiondiscounts) | **GET** /v1/subscription/{handle}/discount | Get subscription discounts
[**GetSubscriptionPaymentMethods**](SubscriptionApi.md#getsubscriptionpaymentmethods) | **GET** /v1/subscription/{handle}/payment_method | Get payment methods
[**GetSubscriptionPeriodBalance**](SubscriptionApi.md#getsubscriptionperiodbalance) | **GET** /v1/subscription/{handle}/period_balance | Get the period balance for subscription
[**GetSubscriptions**](SubscriptionApi.md#getsubscriptions) | **GET** /v1/subscription | Get list of subscriptions
[**IntervalAmount**](SubscriptionApi.md#intervalamount) | **GET** /v1/subscription/{handle}/interval_amount | Calculate interval amount
[**OnHold**](SubscriptionApi.md#onhold) | **POST** /v1/subscription/{handle}/on_hold | Subscription on hold
[**ReactivateSubscription**](SubscriptionApi.md#reactivatesubscription) | **POST** /v1/subscription/{handle}/reactivate | Reactivate subscription on hold
[**RedeemCouponCode**](SubscriptionApi.md#redeemcouponcode) | **POST** /v1/subscription/{handle}/coupon | Redeem coupon code for subscription
[**RemoveAllPaymentMethods**](SubscriptionApi.md#removeallpaymentmethods) | **DELETE** /v1/subscription/{handle}/payment_method | Remove all payment methods
[**RemovePaymentMethod**](SubscriptionApi.md#removepaymentmethod) | **DELETE** /v1/subscription/{handle}/payment_method/{method_id} | Remove payment method
[**SetCardPaymentMethodJson**](SubscriptionApi.md#setcardpaymentmethodjson) | **POST** /v1/subscription/{handle}/payment_method/card | Set card payment method
[**Uncancel**](SubscriptionApi.md#uncancel) | **POST** /v1/subscription/{handle}/uncancel | Uncancel subscription


<a name="cancelchangeplan"></a>
# **CancelChangePlan**
> Subscription CancelChangePlan (string handle)

Cancel pending plan change



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelChangePlanExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle

            try
            {
                // Cancel pending plan change
                Subscription result = apiInstance.CancelChangePlan(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.CancelChangePlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelsubscription"></a>
# **CancelSubscription**
> Subscription CancelSubscription (string handle, CancelSubscription body = null)

Cancel subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new CancelSubscription(); // CancelSubscription |  (optional) 

            try
            {
                // Cancel subscription
                Subscription result = apiInstance.CancelSubscription(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.CancelSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**CancelSubscription**](CancelSubscription.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changenextperiodstartjson"></a>
# **ChangeNextPeriodStartJson**
> Subscription ChangeNextPeriodStartJson (string handle, ChangeNextPeriodStart body = null)

Change next renewal date



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeNextPeriodStartJsonExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new ChangeNextPeriodStart(); // ChangeNextPeriodStart |  (optional) 

            try
            {
                // Change next renewal date
                Subscription result = apiInstance.ChangeNextPeriodStartJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ChangeNextPeriodStartJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**ChangeNextPeriodStart**](ChangeNextPeriodStart.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeplanjson"></a>
# **ChangePlanJson**
> Subscription ChangePlanJson (string handle, ChangePlan body = null)

Change plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangePlanJsonExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new ChangePlan(); // ChangePlan |  (optional) 

            try
            {
                // Change plan
                Subscription result = apiInstance.ChangePlanJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ChangePlanJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**ChangePlan**](ChangePlan.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscriptiondiscount"></a>
# **CreateSubscriptionDiscount**
> SubscriptionDiscount CreateSubscriptionDiscount (string handle, CreateSubscriptionDiscount body = null)

Add subscription discount



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSubscriptionDiscountExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new CreateSubscriptionDiscount(); // CreateSubscriptionDiscount |  (optional) 

            try
            {
                // Add subscription discount
                SubscriptionDiscount result = apiInstance.CreateSubscriptionDiscount(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.CreateSubscriptionDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**CreateSubscriptionDiscount**](CreateSubscriptionDiscount.md)|  | [optional] 

### Return type

[**SubscriptionDiscount**](SubscriptionDiscount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscriptioninvoice"></a>
# **CreateSubscriptionInvoice**
> Invoice CreateSubscriptionInvoice (string handle, CreateSubscriptionInvoice body = null)

Create invoice ondemand for subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSubscriptionInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new CreateSubscriptionInvoice(); // CreateSubscriptionInvoice |  (optional) 

            try
            {
                // Create invoice ondemand for subscription
                Invoice result = apiInstance.CreateSubscriptionInvoice(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.CreateSubscriptionInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**CreateSubscriptionInvoice**](CreateSubscriptionInvoice.md)|  | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscriptionjson"></a>
# **CreateSubscriptionJson**
> Subscription CreateSubscriptionJson (CreateSubscription body = null)

Create subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSubscriptionJsonExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var body = new CreateSubscription(); // CreateSubscription |  (optional) 

            try
            {
                // Create subscription
                Subscription result = apiInstance.CreateSubscriptionJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.CreateSubscriptionJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSubscription**](CreateSubscription.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscriptiondiscount"></a>
# **DeleteSubscriptionDiscount**
> SubscriptionDiscount DeleteSubscriptionDiscount (string handle, string sdHandle)

Delete subscription discount



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubscriptionDiscountExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var sdHandle = sdHandle_example;  // string | Subscription discount handle

            try
            {
                // Delete subscription discount
                SubscriptionDiscount result = apiInstance.DeleteSubscriptionDiscount(handle, sdHandle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.DeleteSubscriptionDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **sdHandle** | **string**| Subscription discount handle | 

### Return type

[**SubscriptionDiscount**](SubscriptionDiscount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expire"></a>
# **Expire**
> Subscription Expire (string handle, ExpireSubscription body = null)

Expire subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpireExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new ExpireSubscription(); // ExpireSubscription |  (optional) 

            try
            {
                // Expire subscription
                Subscription result = apiInstance.Expire(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.Expire: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**ExpireSubscription**](ExpireSubscription.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> Subscription GetSubscription (string handle)

Get subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle

            try
            {
                // Get subscription
                Subscription result = apiInstance.GetSubscription(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiondiscount"></a>
# **GetSubscriptionDiscount**
> SubscriptionDiscount GetSubscriptionDiscount (string handle, string sdHandle)

Get subscription discount



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionDiscountExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var sdHandle = sdHandle_example;  // string | Subscription discount handle

            try
            {
                // Get subscription discount
                SubscriptionDiscount result = apiInstance.GetSubscriptionDiscount(handle, sdHandle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscriptionDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **sdHandle** | **string**| Subscription discount handle | 

### Return type

[**SubscriptionDiscount**](SubscriptionDiscount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiondiscounts"></a>
# **GetSubscriptionDiscounts**
> List<SubscriptionDiscount> GetSubscriptionDiscounts (string handle)

Get subscription discounts



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionDiscountsExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle

            try
            {
                // Get subscription discounts
                List&lt;SubscriptionDiscount&gt; result = apiInstance.GetSubscriptionDiscounts(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscriptionDiscounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 

### Return type

[**List<SubscriptionDiscount>**](SubscriptionDiscount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionpaymentmethods"></a>
# **GetSubscriptionPaymentMethods**
> PaymentMethods GetSubscriptionPaymentMethods (string handle)

Get payment methods



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionPaymentMethodsExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle

            try
            {
                // Get payment methods
                PaymentMethods result = apiInstance.GetSubscriptionPaymentMethods(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscriptionPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 

### Return type

[**PaymentMethods**](PaymentMethods.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionperiodbalance"></a>
# **GetSubscriptionPeriodBalance**
> SubscriptionPeriodBalance GetSubscriptionPeriodBalance (string handle, string date = null)

Get the period balance for subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionPeriodBalanceExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var date = date_example;  // string | Optional period date (default now) on the form `yyyy-MM-dd`, `yyyyMMdd`, `yyyy-MM-ddTHH:mm` and `yyyy-MM-ddTHH:mm:ss` (optional) 

            try
            {
                // Get the period balance for subscription
                SubscriptionPeriodBalance result = apiInstance.GetSubscriptionPeriodBalance(handle, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscriptionPeriodBalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **date** | **string**| Optional period date (default now) on the form &#x60;yyyy-MM-dd&#x60;, &#x60;yyyyMMdd&#x60;, &#x60;yyyy-MM-ddTHH:mm&#x60; and &#x60;yyyy-MM-ddTHH:mm:ss&#x60; | [optional] 

### Return type

[**SubscriptionPeriodBalance**](SubscriptionPeriodBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptions"></a>
# **GetSubscriptions**
> SubscriptionSearch GetSubscriptions (int? page = null, int? size = null, string search = null, string sort = null)

Get list of subscriptions



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionsExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var page = 1;  // int? | Page number to get (optional)  (default to 1)
            var size = 56;  // int? | Page size to use (optional)  (default to 20)
            var search = search_example;  // string | Optional search expression (optional) 
            var sort = sort_example;  // string | Optional sorting expression (optional) 

            try
            {
                // Get list of subscriptions
                SubscriptionSearch result = apiInstance.GetSubscriptions(page, size, search, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.GetSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to get | [optional] [default to 1]
 **size** | **int?**| Page size to use | [optional] [default to 20]
 **search** | **string**| Optional search expression | [optional] 
 **sort** | **string**| Optional sorting expression | [optional] 

### Return type

[**SubscriptionSearch**](SubscriptionSearch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="intervalamount"></a>
# **IntervalAmount**
> IntervalAmount IntervalAmount (string handle, string from, string to)

Calculate interval amount



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntervalAmountExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var from = 2015-05-30;  // string | From date on the form yyyy-MM-dd
            var to = 2015-07-15;  // string | To date on the form yyyy-MM-dd

            try
            {
                // Calculate interval amount
                IntervalAmount result = apiInstance.IntervalAmount(handle, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.IntervalAmount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **from** | **string**| From date on the form yyyy-MM-dd | 
 **to** | **string**| To date on the form yyyy-MM-dd | 

### Return type

[**IntervalAmount**](IntervalAmount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="onhold"></a>
# **OnHold**
> Subscription OnHold (string handle, OnHoldSubscription body = null)

Subscription on hold



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OnHoldExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new OnHoldSubscription(); // OnHoldSubscription |  (optional) 

            try
            {
                // Subscription on hold
                Subscription result = apiInstance.OnHold(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.OnHold: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**OnHoldSubscription**](OnHoldSubscription.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactivatesubscription"></a>
# **ReactivateSubscription**
> Subscription ReactivateSubscription (string handle, ReactivateSubscription body = null)

Reactivate subscription on hold



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReactivateSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new ReactivateSubscription(); // ReactivateSubscription |  (optional) 

            try
            {
                // Reactivate subscription on hold
                Subscription result = apiInstance.ReactivateSubscription(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ReactivateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**ReactivateSubscription**](ReactivateSubscription.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redeemcouponcode"></a>
# **RedeemCouponCode**
> CouponRedemption RedeemCouponCode (string handle, RedeemCouponCode body = null)

Redeem coupon code for subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RedeemCouponCodeExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new RedeemCouponCode(); // RedeemCouponCode |  (optional) 

            try
            {
                // Redeem coupon code for subscription
                CouponRedemption result = apiInstance.RedeemCouponCode(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.RedeemCouponCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**RedeemCouponCode**](RedeemCouponCode.md)|  | [optional] 

### Return type

[**CouponRedemption**](CouponRedemption.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeallpaymentmethods"></a>
# **RemoveAllPaymentMethods**
> PaymentMethods RemoveAllPaymentMethods (string handle)

Remove all payment methods



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveAllPaymentMethodsExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle

            try
            {
                // Remove all payment methods
                PaymentMethods result = apiInstance.RemoveAllPaymentMethods(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.RemoveAllPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 

### Return type

[**PaymentMethods**](PaymentMethods.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removepaymentmethod"></a>
# **RemovePaymentMethod**
> PaymentMethods RemovePaymentMethod (string handle, string methodId)

Remove payment method



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemovePaymentMethodExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var methodId = methodId_example;  // string | Payment method id

            try
            {
                // Remove payment method
                PaymentMethods result = apiInstance.RemovePaymentMethod(handle, methodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.RemovePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **methodId** | **string**| Payment method id | 

### Return type

[**PaymentMethods**](PaymentMethods.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcardpaymentmethodjson"></a>
# **SetCardPaymentMethodJson**
> PaymentMethods SetCardPaymentMethodJson (string handle, SetCardPaymentMethod body = null)

Set card payment method



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetCardPaymentMethodJsonExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new SetCardPaymentMethod(); // SetCardPaymentMethod |  (optional) 

            try
            {
                // Set card payment method
                PaymentMethods result = apiInstance.SetCardPaymentMethodJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.SetCardPaymentMethodJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**SetCardPaymentMethod**](SetCardPaymentMethod.md)|  | [optional] 

### Return type

[**PaymentMethods**](PaymentMethods.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uncancel"></a>
# **Uncancel**
> Subscription Uncancel (string handle)

Uncancel subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UncancelExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionApi();
            var handle = handle_example;  // string | Subscription handle

            try
            {
                // Uncancel subscription
                Subscription result = apiInstance.Uncancel(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.Uncancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

