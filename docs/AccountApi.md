# IO.Swagger.Api.AccountApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePrivateKey**](AccountApi.md#createprivatekey) | **POST** /v1/account/privkey | Create private key
[**CreatePublicKey**](AccountApi.md#createpublickey) | **POST** /v1/account/pubkey | Create public key
[**ExpirePrivateKey**](AccountApi.md#expireprivatekey) | **POST** /v1/account/privkey/{key}/expire | Expire private key
[**ExpirePublicKey**](AccountApi.md#expirepublickey) | **POST** /v1/account/pubkey/{key}/expire | Expire public key
[**GenerateWebhookSecret**](AccountApi.md#generatewebhooksecret) | **POST** /v1/account/webhook_settings/secret | Generate new webhook secret
[**GetCurrentAccount**](AccountApi.md#getcurrentaccount) | **GET** /v1/account | Get account
[**GetDiscountSettings**](AccountApi.md#getdiscountsettings) | **GET** /v1/account/discount_settings | Get discount settings
[**GetMailSettings**](AccountApi.md#getmailsettings) | **GET** /v1/account/mail_settings | Get mail settings
[**GetPrivateKeys**](AccountApi.md#getprivatekeys) | **GET** /v1/account/privkey | Get list of private keys
[**GetPublicKeys**](AccountApi.md#getpublickeys) | **GET** /v1/account/pubkey | Get list of public keys
[**GetWebhookSettings**](AccountApi.md#getwebhooksettings) | **GET** /v1/account/webhook_settings | Get webhook settings
[**UpdateAccountJson**](AccountApi.md#updateaccountjson) | **PUT** /v1/account | Update account
[**UpdateDiscountSettings**](AccountApi.md#updatediscountsettings) | **PUT** /v1/account/discount_settings | Update discount settings
[**UpdateMailSettingsJson**](AccountApi.md#updatemailsettingsjson) | **PUT** /v1/account/mail_settings | Update mail settings
[**UpdateWebhookSettingsJson**](AccountApi.md#updatewebhooksettingsjson) | **PUT** /v1/account/webhook_settings | Update webhook settings


<a name="createprivatekey"></a>
# **CreatePrivateKey**
> Key CreatePrivateKey ()

Create private key



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePrivateKeyExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Create private key
                Key result = apiInstance.CreatePrivateKey();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.CreatePrivateKey: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Key**](Key.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpublickey"></a>
# **CreatePublicKey**
> Key CreatePublicKey ()

Create public key



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePublicKeyExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Create public key
                Key result = apiInstance.CreatePublicKey();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.CreatePublicKey: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Key**](Key.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expireprivatekey"></a>
# **ExpirePrivateKey**
> void ExpirePrivateKey (string key)

Expire private key



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpirePrivateKeyExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var key = key_example;  // string | Private key

            try
            {
                // Expire private key
                apiInstance.ExpirePrivateKey(key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.ExpirePrivateKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Private key | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expirepublickey"></a>
# **ExpirePublicKey**
> void ExpirePublicKey (string key)

Expire public key



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpirePublicKeyExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var key = key_example;  // string | Public key

            try
            {
                // Expire public key
                apiInstance.ExpirePublicKey(key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.ExpirePublicKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Public key | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatewebhooksecret"></a>
# **GenerateWebhookSecret**
> WebhookSettings GenerateWebhookSecret ()

Generate new webhook secret



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateWebhookSecretExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Generate new webhook secret
                WebhookSettings result = apiInstance.GenerateWebhookSecret();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GenerateWebhookSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WebhookSettings**](WebhookSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentaccount"></a>
# **GetCurrentAccount**
> Account GetCurrentAccount ()

Get account



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrentAccountExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Get account
                Account result = apiInstance.GetCurrentAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetCurrentAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiscountsettings"></a>
# **GetDiscountSettings**
> DiscountSettings GetDiscountSettings ()

Get discount settings



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDiscountSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Get discount settings
                DiscountSettings result = apiInstance.GetDiscountSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetDiscountSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DiscountSettings**](DiscountSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmailsettings"></a>
# **GetMailSettings**
> MailSettings GetMailSettings ()

Get mail settings



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Get mail settings
                MailSettings result = apiInstance.GetMailSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetMailSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MailSettings**](MailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprivatekeys"></a>
# **GetPrivateKeys**
> List<Key> GetPrivateKeys ()

Get list of private keys



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPrivateKeysExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Get list of private keys
                List&lt;Key&gt; result = apiInstance.GetPrivateKeys();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetPrivateKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Key>**](Key.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublickeys"></a>
# **GetPublicKeys**
> List<Key> GetPublicKeys ()

Get list of public keys



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPublicKeysExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Get list of public keys
                List&lt;Key&gt; result = apiInstance.GetPublicKeys();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetPublicKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Key>**](Key.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksettings"></a>
# **GetWebhookSettings**
> WebhookSettings GetWebhookSettings ()

Get webhook settings



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebhookSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();

            try
            {
                // Get webhook settings
                WebhookSettings result = apiInstance.GetWebhookSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetWebhookSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WebhookSettings**](WebhookSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccountjson"></a>
# **UpdateAccountJson**
> Account UpdateAccountJson (UpdateAccount body = null)

Update account



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAccountJsonExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var body = new UpdateAccount(); // UpdateAccount |  (optional) 

            try
            {
                // Update account
                Account result = apiInstance.UpdateAccountJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UpdateAccountJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateAccount**](UpdateAccount.md)|  | [optional] 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatediscountsettings"></a>
# **UpdateDiscountSettings**
> DiscountSettings UpdateDiscountSettings (DiscountSettings body = null)

Update discount settings



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateDiscountSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var body = new DiscountSettings(); // DiscountSettings |  (optional) 

            try
            {
                // Update discount settings
                DiscountSettings result = apiInstance.UpdateDiscountSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UpdateDiscountSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiscountSettings**](DiscountSettings.md)|  | [optional] 

### Return type

[**DiscountSettings**](DiscountSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemailsettingsjson"></a>
# **UpdateMailSettingsJson**
> MailSettings UpdateMailSettingsJson (MailSettings body = null)

Update mail settings



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMailSettingsJsonExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var body = new MailSettings(); // MailSettings |  (optional) 

            try
            {
                // Update mail settings
                MailSettings result = apiInstance.UpdateMailSettingsJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UpdateMailSettingsJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MailSettings**](MailSettings.md)|  | [optional] 

### Return type

[**MailSettings**](MailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhooksettingsjson"></a>
# **UpdateWebhookSettingsJson**
> WebhookSettings UpdateWebhookSettingsJson (UpdateWebhookSettings body = null)

Update webhook settings



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateWebhookSettingsJsonExample
    {
        public void main()
        {
            
            var apiInstance = new AccountApi();
            var body = new UpdateWebhookSettings(); // UpdateWebhookSettings |  (optional) 

            try
            {
                // Update webhook settings
                WebhookSettings result = apiInstance.UpdateWebhookSettingsJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UpdateWebhookSettingsJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateWebhookSettings**](UpdateWebhookSettings.md)|  | [optional] 

### Return type

[**WebhookSettings**](WebhookSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

