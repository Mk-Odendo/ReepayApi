# IO.Swagger.Model.CancelSubscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NoticePeriods** | **int?** | Optional override of the notice periods set for plan. See plan for the definition of notice periods. | [optional] 
**NoticePeriodsAfterCurrent** | **bool?** | Optional override of the notice periods after current setting for plan. See plan for the definition of notice periods. | [optional] [default to false]
**ExpireAt** | **string** | Optional fixed date and time on when the subscription should expire. The fixed expire date takes precedence over notice periods and fixation periods. The fixed expire date must be after the end of the current periods. On the form &#x60;yyyy-MM-dd&#x60;, &#x60;yyyyMMdd&#x60;, &#x60;yyyy-MM-ddTHH:mm&#x60; and &#x60;yyyy-MM-ddTHH:mm:ss&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

