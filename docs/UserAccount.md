# IO.Swagger.Model.UserAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique id for the user assigned by Reepay | 
**Email** | **string** | User email | 
**Name** | **string** | User name | [optional] 
**State** | **string** | State of user for account: &#x60;active&#x60;, &#x60;invited&#x60; | 
**Groups** | **List&lt;string&gt;** | List of user groups | 
**Permissions** | **List&lt;string&gt;** | List of user permissions | 
**VerifiedEmail** | **bool?** | Email verified | [default to false]
**InviteExpires** | **DateTime?** | Expiry date for invite | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

