# IO.Swagger.Model.DunningPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Dunning plan name | 
**Schedule** | **List&lt;int?&gt;** | The schedule as list of intervals in days | 
**Handle** | **string** | Per account unique handle for the customer. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. | 
**State** | **string** | State of dunning plan, one of the following: &#x60;active&#x60;, &#x60;deleted&#x60;. | 
**Created** | **DateTime?** | Date when the dunning plan was created. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**DefaultPlan** | **bool?** | If this is default plan | [default to false]
**FinalSubscriptionAction** | **string** | Action to take for subscription if dunning fails, one of the following: &#x60;expire&#x60;, &#x60;on_hold&#x60;, &#x60;none&#x60; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

