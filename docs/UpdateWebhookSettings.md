# IO.Swagger.Model.UpdateWebhookSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Urls** | **List&lt;string&gt;** | Webhook urls | 
**Username** | **string** | Optional HTTP Basic Auth username | [optional] 
**Password** | **string** | Optional HTTP Basic Auth password | [optional] 
**Disabled** | **bool?** | Webhook disabled | [default to false]
**AlertEmails** | **List&lt;string&gt;** | Optional list of emails to send alert to if webhook fails | [optional] 
**AlertCount** | **int?** | Number of requests to perform before alert email is sent, must be greater than or equal to four (1 hour) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

