# IO.Swagger.Api.MailTemplateApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSample**](MailTemplateApi.md#getsample) | **GET** /v1/mail_template/sample | Get sample data


<a name="getsample"></a>
# **GetSample**
> Dictionary<string, Object> GetSample ()

Get sample data



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSampleExample
    {
        public void main()
        {
            
            var apiInstance = new MailTemplateApi();

            try
            {
                // Get sample data
                Dictionary&lt;string, Object&gt; result = apiInstance.GetSample();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailTemplateApi.GetSample: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

