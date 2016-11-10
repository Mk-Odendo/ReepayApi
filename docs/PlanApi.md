# IO.Swagger.Api.PlanApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePlanJson**](PlanApi.md#createplanjson) | **POST** /v1/plan | Create plan
[**DeletePlan**](PlanApi.md#deleteplan) | **DELETE** /v1/plan/{handle} | Delete plan
[**GetCurrentPlan**](PlanApi.md#getcurrentplan) | **GET** /v1/plan/{handle}/current | Get plan
[**GetPlan**](PlanApi.md#getplan) | **GET** /v1/plan/{handle}/{version} | Get plan version
[**GetPlans**](PlanApi.md#getplans) | **GET** /v1/plan/{handle} | Get list of plan versions
[**GetPlansList**](PlanApi.md#getplanslist) | **GET** /v1/plan | Get list of plans
[**SupersedePlanJson**](PlanApi.md#supersedeplanjson) | **POST** /v1/plan/{handle} | Supersede plan
[**UpdatePlanJson**](PlanApi.md#updateplanjson) | **PUT** /v1/plan/{handle} | Update plan


<a name="createplanjson"></a>
# **CreatePlanJson**
> Plan CreatePlanJson (CreateSubscriptionPlan body = null)

Create plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePlanJsonExample
    {
        public void main()
        {
            
            var apiInstance = new PlanApi();
            var body = new CreateSubscriptionPlan(); // CreateSubscriptionPlan |  (optional) 

            try
            {
                // Create plan
                Plan result = apiInstance.CreatePlanJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.CreatePlanJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateSubscriptionPlan**](CreateSubscriptionPlan.md)|  | [optional] 

### Return type

[**Plan**](Plan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteplan"></a>
# **DeletePlan**
> Plan DeletePlan (string handle)

Delete plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePlanExample
    {
        public void main()
        {
            
            var apiInstance = new PlanApi();
            var handle = handle_example;  // string | Subscription plan handle

            try
            {
                // Delete plan
                Plan result = apiInstance.DeletePlan(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.DeletePlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription plan handle | 

### Return type

[**Plan**](Plan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentplan"></a>
# **GetCurrentPlan**
> Plan GetCurrentPlan (string handle)

Get plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrentPlanExample
    {
        public void main()
        {
            
            var apiInstance = new PlanApi();
            var handle = handle_example;  // string | Plan handle

            try
            {
                // Get plan
                Plan result = apiInstance.GetCurrentPlan(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.GetCurrentPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Plan handle | 

### Return type

[**Plan**](Plan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplan"></a>
# **GetPlan**
> Plan GetPlan (string handle, int? version)

Get plan version



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlanExample
    {
        public void main()
        {
            
            var apiInstance = new PlanApi();
            var handle = handle_example;  // string | Plan handle
            var version = 56;  // int? | Plan version

            try
            {
                // Get plan version
                Plan result = apiInstance.GetPlan(handle, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.GetPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Plan handle | 
 **version** | **int?**| Plan version | 

### Return type

[**Plan**](Plan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplans"></a>
# **GetPlans**
> List<Plan> GetPlans (string handle)

Get list of plan versions



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlansExample
    {
        public void main()
        {
            
            var apiInstance = new PlanApi();
            var handle = handle_example;  // string | Plan handle

            try
            {
                // Get list of plan versions
                List&lt;Plan&gt; result = apiInstance.GetPlans(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.GetPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Plan handle | 

### Return type

[**List<Plan>**](Plan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplanslist"></a>
# **GetPlansList**
> List<Plan> GetPlansList (bool? onlyActive = null)

Get list of plans



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlansListExample
    {
        public void main()
        {
            
            var apiInstance = new PlanApi();
            var onlyActive = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get list of plans
                List&lt;Plan&gt; result = apiInstance.GetPlansList(onlyActive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.GetPlansList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onlyActive** | **bool?**|  | [optional] [default to false]

### Return type

[**List<Plan>**](Plan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="supersedeplanjson"></a>
# **SupersedePlanJson**
> Plan SupersedePlanJson (string handle, SupersedeSubscriptionPlan body = null)

Supersede plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SupersedePlanJsonExample
    {
        public void main()
        {
            
            var apiInstance = new PlanApi();
            var handle = handle_example;  // string | Plan handle
            var body = new SupersedeSubscriptionPlan(); // SupersedeSubscriptionPlan |  (optional) 

            try
            {
                // Supersede plan
                Plan result = apiInstance.SupersedePlanJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.SupersedePlanJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Plan handle | 
 **body** | [**SupersedeSubscriptionPlan**](SupersedeSubscriptionPlan.md)|  | [optional] 

### Return type

[**Plan**](Plan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateplanjson"></a>
# **UpdatePlanJson**
> Plan UpdatePlanJson (string handle, UpdateSubscriptionPlan body = null)

Update plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePlanJsonExample
    {
        public void main()
        {
            
            var apiInstance = new PlanApi();
            var handle = handle_example;  // string | Subscription handle
            var body = new UpdateSubscriptionPlan(); // UpdateSubscriptionPlan |  (optional) 

            try
            {
                // Update plan
                Plan result = apiInstance.UpdatePlanJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.UpdatePlanJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscription handle | 
 **body** | [**UpdateSubscriptionPlan**](UpdateSubscriptionPlan.md)|  | [optional] 

### Return type

[**Plan**](Plan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

