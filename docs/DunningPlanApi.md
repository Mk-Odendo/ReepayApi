# IO.Swagger.Api.DunningPlanApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDunningPlanJson**](DunningPlanApi.md#createdunningplanjson) | **POST** /v1/dunning_plan | Create dunning plan
[**DeleteDunningPlan**](DunningPlanApi.md#deletedunningplan) | **DELETE** /v1/dunning_plan/{handle} | Delete dunning plan
[**GetDunningPlan**](DunningPlanApi.md#getdunningplan) | **GET** /v1/dunning_plan/{handle} | Get dunning plan
[**GetDunningPlans**](DunningPlanApi.md#getdunningplans) | **GET** /v1/dunning_plan | Get list of dunning plans
[**UpdateJson**](DunningPlanApi.md#updatejson) | **PUT** /v1/dunning_plan/{handle} | Update dunning plan


<a name="createdunningplanjson"></a>
# **CreateDunningPlanJson**
> DunningPlan CreateDunningPlanJson (CreateDunningPlan body = null)

Create dunning plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDunningPlanJsonExample
    {
        public void main()
        {
            
            var apiInstance = new DunningPlanApi();
            var body = new CreateDunningPlan(); // CreateDunningPlan |  (optional) 

            try
            {
                // Create dunning plan
                DunningPlan result = apiInstance.CreateDunningPlanJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DunningPlanApi.CreateDunningPlanJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateDunningPlan**](CreateDunningPlan.md)|  | [optional] 

### Return type

[**DunningPlan**](DunningPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedunningplan"></a>
# **DeleteDunningPlan**
> DunningPlan DeleteDunningPlan (string handle)

Delete dunning plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDunningPlanExample
    {
        public void main()
        {
            
            var apiInstance = new DunningPlanApi();
            var handle = handle_example;  // string | Dunning plan handle

            try
            {
                // Delete dunning plan
                DunningPlan result = apiInstance.DeleteDunningPlan(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DunningPlanApi.DeleteDunningPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Dunning plan handle | 

### Return type

[**DunningPlan**](DunningPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdunningplan"></a>
# **GetDunningPlan**
> DunningPlan GetDunningPlan (string handle)

Get dunning plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDunningPlanExample
    {
        public void main()
        {
            
            var apiInstance = new DunningPlanApi();
            var handle = handle_example;  // string | Dunning plan handle

            try
            {
                // Get dunning plan
                DunningPlan result = apiInstance.GetDunningPlan(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DunningPlanApi.GetDunningPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Dunning plan handle | 

### Return type

[**DunningPlan**](DunningPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdunningplans"></a>
# **GetDunningPlans**
> List<DunningPlan> GetDunningPlans ()

Get list of dunning plans



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDunningPlansExample
    {
        public void main()
        {
            
            var apiInstance = new DunningPlanApi();

            try
            {
                // Get list of dunning plans
                List&lt;DunningPlan&gt; result = apiInstance.GetDunningPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DunningPlanApi.GetDunningPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DunningPlan>**](DunningPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatejson"></a>
# **UpdateJson**
> DunningPlan UpdateJson (string handle, UpdateDunningPlan body = null)

Update dunning plan



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateJsonExample
    {
        public void main()
        {
            
            var apiInstance = new DunningPlanApi();
            var handle = handle_example;  // string | Dunning plan handle
            var body = new UpdateDunningPlan(); // UpdateDunningPlan |  (optional) 

            try
            {
                // Update dunning plan
                DunningPlan result = apiInstance.UpdateJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DunningPlanApi.UpdateJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Dunning plan handle | 
 **body** | [**UpdateDunningPlan**](UpdateDunningPlan.md)|  | [optional] 

### Return type

[**DunningPlan**](DunningPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

