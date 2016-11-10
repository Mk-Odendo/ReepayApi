# IO.Swagger.Api.CreditApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelCredit**](CreditApi.md#cancelcredit) | **POST** /v1/credit/{handle}/cancel | Cancel credit
[**CreateCreditJson**](CreditApi.md#createcreditjson) | **POST** /v1/credit | Create credit
[**GetCredit**](CreditApi.md#getcredit) | **GET** /v1/credit/{handle} | Get credit
[**GetCredits**](CreditApi.md#getcredits) | **GET** /v1/credit/subscription/{handle} | Get credits for subscription


<a name="cancelcredit"></a>
# **CancelCredit**
> Credit CancelCredit (string handle)

Cancel credit



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelCreditExample
    {
        public void main()
        {
            
            var apiInstance = new CreditApi();
            var handle = handle_example;  // string | Credit handle

            try
            {
                // Cancel credit
                Credit result = apiInstance.CancelCredit(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CancelCredit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Credit handle | 

### Return type

[**Credit**](Credit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcreditjson"></a>
# **CreateCreditJson**
> Credit CreateCreditJson (CreateCredit body = null)

Create credit



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCreditJsonExample
    {
        public void main()
        {
            
            var apiInstance = new CreditApi();
            var body = new CreateCredit(); // CreateCredit |  (optional) 

            try
            {
                // Create credit
                Credit result = apiInstance.CreateCreditJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.CreateCreditJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCredit**](CreateCredit.md)|  | [optional] 

### Return type

[**Credit**](Credit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcredit"></a>
# **GetCredit**
> Credit GetCredit (string handle)

Get credit



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditExample
    {
        public void main()
        {
            
            var apiInstance = new CreditApi();
            var handle = handle_example;  // string | Credit handle

            try
            {
                // Get credit
                Credit result = apiInstance.GetCredit(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.GetCredit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Credit handle | 

### Return type

[**Credit**](Credit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcredits"></a>
# **GetCredits**
> List<Credit> GetCredits (string handle)

Get credits for subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditsExample
    {
        public void main()
        {
            
            var apiInstance = new CreditApi();
            var handle = handle_example;  // string | Subscription handle

            try
            {
                // Get credits for subscription
                List&lt;Credit&gt; result = apiInstance.GetCredits(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditApi.GetCredits: " + e.Message );
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

[**List<Credit>**](Credit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

