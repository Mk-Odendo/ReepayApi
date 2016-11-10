# IO.Swagger.Api.OrganisationApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrganisation**](OrganisationApi.md#getorganisation) | **GET** /v1/organisation | Get organisation
[**Update**](OrganisationApi.md#update) | **PUT** /v1/organisation | Update organisation


<a name="getorganisation"></a>
# **GetOrganisation**
> Organisation GetOrganisation ()

Get organisation



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrganisationExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();

            try
            {
                // Get organisation
                Organisation result = apiInstance.GetOrganisation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.GetOrganisation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Organisation**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> Organisation Update (UpdateOrganisation body = null)

Update organisation



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateExample
    {
        public void main()
        {
            
            var apiInstance = new OrganisationApi();
            var body = new UpdateOrganisation(); // UpdateOrganisation |  (optional) 

            try
            {
                // Update organisation
                Organisation result = apiInstance.Update(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateOrganisation**](UpdateOrganisation.md)|  | [optional] 

### Return type

[**Organisation**](Organisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

