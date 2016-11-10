# IO.Swagger.Api.EventApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEvent**](EventApi.md#getevent) | **GET** /v1/event/{id} | Get event
[**GetEvents**](EventApi.md#getevents) | **GET** /v1/event | Get list of events


<a name="getevent"></a>
# **GetEvent**
> ModelEvent GetEvent (string id)

Get event



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventExample
    {
        public void main()
        {
            
            var apiInstance = new EventApi();
            var id = id_example;  // string | Event id

            try
            {
                // Get event
                ModelEvent result = apiInstance.GetEvent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Event id | 

### Return type

[**ModelEvent**](ModelEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevents"></a>
# **GetEvents**
> EventList GetEvents (int? page = null, int? size = null, string customer = null, string subscription = null, string invoice = null)

Get list of events



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {
            
            var apiInstance = new EventApi();
            var page = 1;  // int? | Page number to get (optional)  (default to 1)
            var size = 56;  // int? | Page size to use (optional)  (default to 20)
            var customer = customer_example;  // string | Customer handle (optional) 
            var subscription = subscription_example;  // string | Subscription handle (optional) 
            var invoice = invoice_example;  // string | Invoice id (optional) 

            try
            {
                // Get list of events
                EventList result = apiInstance.GetEvents(page, size, customer, subscription, invoice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEvents: " + e.Message );
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
 **customer** | **string**| Customer handle | [optional] 
 **subscription** | **string**| Subscription handle | [optional] 
 **invoice** | **string**| Invoice id | [optional] 

### Return type

[**EventList**](EventList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

