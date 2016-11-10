# IO.Swagger.Api.AgreementApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCardGatewayAgreement**](AgreementApi.md#createcardgatewayagreement) | **POST** /v1/agreement/card_gateway | Create card gateway agreement
[**DeleteCardGatewayAgreement**](AgreementApi.md#deletecardgatewayagreement) | **DELETE** /v1/agreement/card_gateway/{id} | Delete card gateway agreement
[**GetCardGatewayAgreement**](AgreementApi.md#getcardgatewayagreement) | **GET** /v1/agreement/card_gateway/{id} | Get card gateway agreement
[**GetCardGatewayAgreements**](AgreementApi.md#getcardgatewayagreements) | **GET** /v1/agreement/card_gateway | Get all card gateway agreements
[**UpdateCardGatewayAgreement**](AgreementApi.md#updatecardgatewayagreement) | **PUT** /v1/agreement/card_gateway/{id} | Update card gateway agreement


<a name="createcardgatewayagreement"></a>
# **CreateCardGatewayAgreement**
> CardGatewayAgreement CreateCardGatewayAgreement (CreateCardGatewayAgreement body = null)

Create card gateway agreement



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCardGatewayAgreementExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementApi();
            var body = new CreateCardGatewayAgreement(); // CreateCardGatewayAgreement |  (optional) 

            try
            {
                // Create card gateway agreement
                CardGatewayAgreement result = apiInstance.CreateCardGatewayAgreement(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementApi.CreateCardGatewayAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCardGatewayAgreement**](CreateCardGatewayAgreement.md)|  | [optional] 

### Return type

[**CardGatewayAgreement**](CardGatewayAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecardgatewayagreement"></a>
# **DeleteCardGatewayAgreement**
> CardGatewayAgreement DeleteCardGatewayAgreement (string id)

Delete card gateway agreement



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCardGatewayAgreementExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementApi();
            var id = id_example;  // string | Agreement id

            try
            {
                // Delete card gateway agreement
                CardGatewayAgreement result = apiInstance.DeleteCardGatewayAgreement(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementApi.DeleteCardGatewayAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Agreement id | 

### Return type

[**CardGatewayAgreement**](CardGatewayAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcardgatewayagreement"></a>
# **GetCardGatewayAgreement**
> CardGatewayAgreement GetCardGatewayAgreement (string id)

Get card gateway agreement



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCardGatewayAgreementExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementApi();
            var id = id_example;  // string | Agreement id

            try
            {
                // Get card gateway agreement
                CardGatewayAgreement result = apiInstance.GetCardGatewayAgreement(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementApi.GetCardGatewayAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Agreement id | 

### Return type

[**CardGatewayAgreement**](CardGatewayAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcardgatewayagreements"></a>
# **GetCardGatewayAgreements**
> List<CardGatewayAgreement> GetCardGatewayAgreements (bool? onlyActive = null)

Get all card gateway agreements



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCardGatewayAgreementsExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementApi();
            var onlyActive = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get all card gateway agreements
                List&lt;CardGatewayAgreement&gt; result = apiInstance.GetCardGatewayAgreements(onlyActive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementApi.GetCardGatewayAgreements: " + e.Message );
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

[**List<CardGatewayAgreement>**](CardGatewayAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecardgatewayagreement"></a>
# **UpdateCardGatewayAgreement**
> CardGatewayAgreement UpdateCardGatewayAgreement (string id, UpdateCardGatewayAgreement body = null)

Update card gateway agreement



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCardGatewayAgreementExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementApi();
            var id = id_example;  // string | Agreement id
            var body = new UpdateCardGatewayAgreement(); // UpdateCardGatewayAgreement |  (optional) 

            try
            {
                // Update card gateway agreement
                CardGatewayAgreement result = apiInstance.UpdateCardGatewayAgreement(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementApi.UpdateCardGatewayAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Agreement id | 
 **body** | [**UpdateCardGatewayAgreement**](UpdateCardGatewayAgreement.md)|  | [optional] 

### Return type

[**CardGatewayAgreement**](CardGatewayAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

