# IO.Swagger.Api.AuthenticateApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](AuthenticateApi.md#login) | **POST** /v1/authenticate/login | User login
[**Renew**](AuthenticateApi.md#renew) | **POST** /v1/authenticate/renew | Renew user login
[**VerifyAuthentication**](AuthenticateApi.md#verifyauthentication) | **GET** /v1/authenticate/verify | Verify authentication


<a name="login"></a>
# **Login**
> UserLogin Login (string email = null, string password = null, string organisation = null, string account = null)

User login



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticateApi();
            var email = email_example;  // string | User email (optional) 
            var password = password_example;  // string | User password (optional) 
            var organisation = organisation_example;  // string | Organisation subdomain to login to (optional) 
            var account = account_example;  // string | Account handle or id to login to (optional) 

            try
            {
                // User login
                UserLogin result = apiInstance.Login(email, password, organisation, account);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticateApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| User email | [optional] 
 **password** | **string**| User password | [optional] 
 **organisation** | **string**| Organisation subdomain to login to | [optional] 
 **account** | **string**| Account handle or id to login to | [optional] 

### Return type

[**UserLogin**](UserLogin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renew"></a>
# **Renew**
> UserRenew Renew ()

Renew user login



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RenewExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticateApi();

            try
            {
                // Renew user login
                UserRenew result = apiInstance.Renew();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticateApi.Renew: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserRenew**](UserRenew.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyauthentication"></a>
# **VerifyAuthentication**
> void VerifyAuthentication ()

Verify authentication



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyAuthenticationExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticateApi();

            try
            {
                // Verify authentication
                apiInstance.VerifyAuthentication();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticateApi.VerifyAuthentication: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

