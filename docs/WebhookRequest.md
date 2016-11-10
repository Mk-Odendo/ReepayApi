# IO.Swagger.Model.WebhookRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique webhook id assigned by Reepay | 
**Initiated** | **DateTime?** | Date when the webhook request was initiated, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Duration** | **long?** | Duration in milliseconds of request | 
**Headers** | **string** | HTTP headers received, null if no response | [optional] 
**Content** | **string** | Truncated content received, null if no response | [optional] 
**HttpStatus** | **int?** | HTTP status code received, null if no response | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

