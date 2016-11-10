# IO.Swagger.Model.UserLogin
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | Authentication token to use in X-Auth-Token | 
**User** | [**User**](User.md) | Logged in user | 
**Account** | [**AccountLogin**](AccountLogin.md) | Account logged into | 
**Organisation** | [**Organisation**](Organisation.md) | Organisation for account logged into | 
**Organisations** | [**List&lt;OrganisationLogin&gt;**](OrganisationLogin.md) | List of organisations for user | 
**Groups** | **List&lt;string&gt;** | List user groups | 
**Permissions** | **List&lt;string&gt;** | List user permissions | 
**TokenTtl** | **int?** | Token time-to-live in minutes | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

