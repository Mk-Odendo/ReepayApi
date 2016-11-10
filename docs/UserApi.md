# IO.Swagger.Api.UserApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUser**](UserApi.md#deleteuser) | **DELETE** /v1/user/{id} | Delete user
[**GetUser**](UserApi.md#getuser) | **GET** /v1/user/{id} | Get user
[**GetUsers**](UserApi.md#getusers) | **GET** /v1/user | Get users
[**InviteUser**](UserApi.md#inviteuser) | **POST** /v1/user/invite | Invite user
[**InviteUserAccept**](UserApi.md#inviteuseraccept) | **POST** /v1/user/invite/{token} | Accept invite
[**InviteUserGet**](UserApi.md#inviteuserget) | **GET** /v1/user/invite/{token} | Get invite
[**ResetPassword**](UserApi.md#resetpassword) | **POST** /v1/user/reset_password | Reset password request
[**ResetPasswordWithToken**](UserApi.md#resetpasswordwithtoken) | **POST** /v1/user/reset_password/{token} | Reset password
[**UpdateAuth**](UserApi.md#updateauth) | **PUT** /v1/user/{id}/groups | Update user groups
[**UpdatePassword**](UserApi.md#updatepassword) | **PUT** /v1/user/{id}/password | Change password
[**UpdateUser**](UserApi.md#updateuser) | **PUT** /v1/user/{id} | Update user
[**VerifyEmail**](UserApi.md#verifyemail) | **POST** /v1/user/verify_email/{token} | Verify email
[**VerifyEmailRequest**](UserApi.md#verifyemailrequest) | **POST** /v1/user/{id}/verify_email | Send verification email


<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string id)

Delete user



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = id_example;  // string | User id

            try
            {
                // Delete user
                apiInstance.DeleteUser(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> UserAccount GetUser (string id)

Get user



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = id_example;  // string | User id

            try
            {
                // Get user
                UserAccount result = apiInstance.GetUser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User id | 

### Return type

[**UserAccount**](UserAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> List<UserAccount> GetUsers ()

Get users



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();

            try
            {
                // Get users
                List&lt;UserAccount&gt; result = apiInstance.GetUsers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserAccount>**](UserAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteuser"></a>
# **InviteUser**
> UserAccount InviteUser (InviteUser body = null)

Invite user



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InviteUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var body = new InviteUser(); // InviteUser |  (optional) 

            try
            {
                // Invite user
                UserAccount result = apiInstance.InviteUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.InviteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InviteUser**](InviteUser.md)|  | [optional] 

### Return type

[**UserAccount**](UserAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteuseraccept"></a>
# **InviteUserAccept**
> UserAccount InviteUserAccept (string token, InviteUserAccept body = null)

Accept invite



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InviteUserAcceptExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var token = token_example;  // string | Invite token
            var body = new InviteUserAccept(); // InviteUserAccept |  (optional) 

            try
            {
                // Accept invite
                UserAccount result = apiInstance.InviteUserAccept(token, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.InviteUserAccept: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| Invite token | 
 **body** | [**InviteUserAccept**](InviteUserAccept.md)|  | [optional] 

### Return type

[**UserAccount**](UserAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteuserget"></a>
# **InviteUserGet**
> UserAccount InviteUserGet (string token)

Get invite



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InviteUserGetExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var token = token_example;  // string | Invite token

            try
            {
                // Get invite
                UserAccount result = apiInstance.InviteUserGet(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.InviteUserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| Invite token | 

### Return type

[**UserAccount**](UserAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetpassword"></a>
# **ResetPassword**
> void ResetPassword (UserResetRequestPassword body = null)

Reset password request



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResetPasswordExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var body = new UserResetRequestPassword(); // UserResetRequestPassword |  (optional) 

            try
            {
                // Reset password request
                apiInstance.ResetPassword(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ResetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserResetRequestPassword**](UserResetRequestPassword.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetpasswordwithtoken"></a>
# **ResetPasswordWithToken**
> User ResetPasswordWithToken (string token, UpdateUserPassword body = null)

Reset password



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResetPasswordWithTokenExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var token = token_example;  // string | Reset password token
            var body = new UpdateUserPassword(); // UpdateUserPassword |  (optional) 

            try
            {
                // Reset password
                User result = apiInstance.ResetPasswordWithToken(token, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ResetPasswordWithToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| Reset password token | 
 **body** | [**UpdateUserPassword**](UpdateUserPassword.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateauth"></a>
# **UpdateAuth**
> UserAccount UpdateAuth (string id, UpdateUserGroups body = null)

Update user groups



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAuthExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = id_example;  // string | User id
            var body = new UpdateUserGroups(); // UpdateUserGroups |  (optional) 

            try
            {
                // Update user groups
                UserAccount result = apiInstance.UpdateAuth(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateAuth: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User id | 
 **body** | [**UpdateUserGroups**](UpdateUserGroups.md)|  | [optional] 

### Return type

[**UserAccount**](UserAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepassword"></a>
# **UpdatePassword**
> UserAccount UpdatePassword (string id, UpdateUserPassword body = null)

Change password



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePasswordExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = id_example;  // string | User id
            var body = new UpdateUserPassword(); // UpdateUserPassword |  (optional) 

            try
            {
                // Change password
                UserAccount result = apiInstance.UpdatePassword(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdatePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User id | 
 **body** | [**UpdateUserPassword**](UpdateUserPassword.md)|  | [optional] 

### Return type

[**UserAccount**](UserAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> UserAccount UpdateUser (string id, UpdateUser body = null)

Update user



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = id_example;  // string | User id
            var body = new UpdateUser(); // UpdateUser |  (optional) 

            try
            {
                // Update user
                UserAccount result = apiInstance.UpdateUser(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User id | 
 **body** | [**UpdateUser**](UpdateUser.md)|  | [optional] 

### Return type

[**UserAccount**](UserAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyemail"></a>
# **VerifyEmail**
> User VerifyEmail (string token)

Verify email



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyEmailExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var token = token_example;  // string | Verify email token

            try
            {
                // Verify email
                User result = apiInstance.VerifyEmail(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.VerifyEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| Verify email token | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyemailrequest"></a>
# **VerifyEmailRequest**
> void VerifyEmailRequest (string id)

Send verification email



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerifyEmailRequestExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var id = id_example;  // string | User id

            try
            {
                // Send verification email
                apiInstance.VerifyEmailRequest(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.VerifyEmailRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

