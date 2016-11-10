# IO.Swagger.Api.WebhookApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DisableWebhooks**](WebhookApi.md#disablewebhooks) | **POST** /v1/webhook/disable | Disable webhooks
[**GetWebhook**](WebhookApi.md#getwebhook) | **GET** /v1/webhook/{id} | Get webhooks
[**GetWebhookRequests**](WebhookApi.md#getwebhookrequests) | **GET** /v1/webhook/{id}/request | Get webhook requests
[**GetWebhooks**](WebhookApi.md#getwebhooks) | **GET** /v1/webhook | Get list of webhooks
[**ResendJson**](WebhookApi.md#resendjson) | **POST** /v1/webhook/resend | Re-send webhooks
[**UpdateWebhooks**](WebhookApi.md#updatewebhooks) | **POST** /v1/webhook/update | Update and resend webhooks


<a name="disablewebhooks"></a>
# **DisableWebhooks**
> List<Webhook> DisableWebhooks (WebhookDisableRequest body = null)

Disable webhooks



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisableWebhooksExample
    {
        public void main()
        {
            
            var apiInstance = new WebhookApi();
            var body = new WebhookDisableRequest(); // WebhookDisableRequest |  (optional) 

            try
            {
                // Disable webhooks
                List&lt;Webhook&gt; result = apiInstance.DisableWebhooks(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.DisableWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookDisableRequest**](WebhookDisableRequest.md)|  | [optional] 

### Return type

[**List<Webhook>**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhook"></a>
# **GetWebhook**
> List<Webhook> GetWebhook (string id)

Get webhooks



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public void main()
        {
            
            var apiInstance = new WebhookApi();
            var id = id_example;  // string | Webhook id or event id

            try
            {
                // Get webhooks
                List&lt;Webhook&gt; result = apiInstance.GetWebhook(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Webhook id or event id | 

### Return type

[**List<Webhook>**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhookrequests"></a>
# **GetWebhookRequests**
> List<WebhookRequest> GetWebhookRequests (string id)

Get webhook requests



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebhookRequestsExample
    {
        public void main()
        {
            
            var apiInstance = new WebhookApi();
            var id = id_example;  // string | Webhook id

            try
            {
                // Get webhook requests
                List&lt;WebhookRequest&gt; result = apiInstance.GetWebhookRequests(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhookRequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Webhook id | 

### Return type

[**List<WebhookRequest>**](WebhookRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> List<Webhook> GetWebhooks (string createdBefore, int? size = null, string state = null)

Get list of webhooks



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            
            var apiInstance = new WebhookApi();
            var createdBefore = 2015-06-14T08:12:19.558+00:00;  // string | Get webhooks created before this date, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. Use last created date as filter for next page.
            var size = 100;  // int? | Page size. A maximum of 100 is allowed. (optional)  (default to 100)
            var state = pending;  // string | Optional state to filter on, one of the following: `pending`, `disabled`, `failed`, `completed` (optional) 

            try
            {
                // Get list of webhooks
                List&lt;Webhook&gt; result = apiInstance.GetWebhooks(createdBefore, size, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createdBefore** | **string**| Get webhooks created before this date, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. Use last created date as filter for next page. | 
 **size** | **int?**| Page size. A maximum of 100 is allowed. | [optional] [default to 100]
 **state** | **string**| Optional state to filter on, one of the following: &#x60;pending&#x60;, &#x60;disabled&#x60;, &#x60;failed&#x60;, &#x60;completed&#x60; | [optional] 

### Return type

[**List<Webhook>**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resendjson"></a>
# **ResendJson**
> List<Webhook> ResendJson (WebhookResendRequest body = null)

Re-send webhooks



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResendJsonExample
    {
        public void main()
        {
            
            var apiInstance = new WebhookApi();
            var body = new WebhookResendRequest(); // WebhookResendRequest |  (optional) 

            try
            {
                // Re-send webhooks
                List&lt;Webhook&gt; result = apiInstance.ResendJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.ResendJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookResendRequest**](WebhookResendRequest.md)|  | [optional] 

### Return type

[**List<Webhook>**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhooks"></a>
# **UpdateWebhooks**
> List<Webhook> UpdateWebhooks (WebhookUpdateRequest body = null)

Update and resend webhooks



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateWebhooksExample
    {
        public void main()
        {
            
            var apiInstance = new WebhookApi();
            var body = new WebhookUpdateRequest(); // WebhookUpdateRequest |  (optional) 

            try
            {
                // Update and resend webhooks
                List&lt;Webhook&gt; result = apiInstance.UpdateWebhooks(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookApi.UpdateWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookUpdateRequest**](WebhookUpdateRequest.md)|  | [optional] 

### Return type

[**List<Webhook>**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

