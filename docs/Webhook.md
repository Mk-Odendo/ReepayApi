# IO.Swagger.Model.Webhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique webhook id assigned by Reepay | 
**_Event** | **string** | Event id of the event this webhook is for | 
**State** | **string** | The webhook state, one of the following: &#x60;pending&#x60;, &#x60;disabled&#x60;, &#x60;failed&#x60;, &#x60;completed&#x60; | 
**Url** | **string** | Webhook url | 
**Username** | **string** | Optional basic auth username | [optional] 
**Password** | **string** | Optional basic auth password (masked) | [optional] 
**Content** | **string** | JSON content of the webhook | 
**Created** | **DateTime?** | Creation date in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Success** | **DateTime?** | Date of successful invocation in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**Count** | **int?** | Number of invocations performed | 
**LastFail** | **DateTime?** | Date of last failed invocation in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**FirstFail** | **DateTime?** | Date of first failed invocation in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**AlertCount** | **int?** | Number of failed invocations before an alert email is sent | [optional] 
**AlertSent** | **DateTime?** | Date when an optional alert email sending was requested in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

