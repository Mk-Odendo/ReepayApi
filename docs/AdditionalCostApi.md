# IO.Swagger.Api.AdditionalCostApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelAdditionalCost**](AdditionalCostApi.md#canceladditionalcost) | **POST** /v1/additional_cost/{handle}/cancel | Cancel pending additional cost
[**CreateAdditionalCostJson**](AdditionalCostApi.md#createadditionalcostjson) | **POST** /v1/additional_cost | Create additional cost
[**GetAdditionalCost**](AdditionalCostApi.md#getadditionalcost) | **GET** /v1/additional_cost/{handle} | Get additional cost
[**GetAdditionalCosts**](AdditionalCostApi.md#getadditionalcosts) | **GET** /v1/additional_cost/subscription/{handle} | Get additional costs for subscription


<a name="canceladditionalcost"></a>
# **CancelAdditionalCost**
> AdditionalCost CancelAdditionalCost (string handle)

Cancel pending additional cost



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelAdditionalCostExample
    {
        public void main()
        {
            
            var apiInstance = new AdditionalCostApi();
            var handle = handle_example;  // string | Additonal cost handle

            try
            {
                // Cancel pending additional cost
                AdditionalCost result = apiInstance.CancelAdditionalCost(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalCostApi.CancelAdditionalCost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Additonal cost handle | 

### Return type

[**AdditionalCost**](AdditionalCost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createadditionalcostjson"></a>
# **CreateAdditionalCostJson**
> AdditionalCost CreateAdditionalCostJson (CreateAdditionalCost body = null)

Create additional cost



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAdditionalCostJsonExample
    {
        public void main()
        {
            
            var apiInstance = new AdditionalCostApi();
            var body = new CreateAdditionalCost(); // CreateAdditionalCost |  (optional) 

            try
            {
                // Create additional cost
                AdditionalCost result = apiInstance.CreateAdditionalCostJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalCostApi.CreateAdditionalCostJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateAdditionalCost**](CreateAdditionalCost.md)|  | [optional] 

### Return type

[**AdditionalCost**](AdditionalCost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadditionalcost"></a>
# **GetAdditionalCost**
> AdditionalCost GetAdditionalCost (string handle)

Get additional cost



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAdditionalCostExample
    {
        public void main()
        {
            
            var apiInstance = new AdditionalCostApi();
            var handle = handle_example;  // string | Additonal cost handle

            try
            {
                // Get additional cost
                AdditionalCost result = apiInstance.GetAdditionalCost(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalCostApi.GetAdditionalCost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Additonal cost handle | 

### Return type

[**AdditionalCost**](AdditionalCost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadditionalcosts"></a>
# **GetAdditionalCosts**
> List<AdditionalCost> GetAdditionalCosts (string handle)

Get additional costs for subscription



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAdditionalCostsExample
    {
        public void main()
        {
            
            var apiInstance = new AdditionalCostApi();
            var handle = handle_example;  // string | Subscription handle

            try
            {
                // Get additional costs for subscription
                List&lt;AdditionalCost&gt; result = apiInstance.GetAdditionalCosts(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalCostApi.GetAdditionalCosts: " + e.Message );
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

[**List<AdditionalCost>**](AdditionalCost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

