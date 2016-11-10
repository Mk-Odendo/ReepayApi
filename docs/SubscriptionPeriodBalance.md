# IO.Swagger.Model.SubscriptionPeriodBalance
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | Date in period for this period balance | [optional] 
**Invoice** | [**Invoice**](Invoice.md) | Invoice for period, if it exists. See &#x60;period_from&#x60; and &#x60;period_to&#x60; for period start and end. | [optional] 
**Paid** | **int?** | The plan amount paid and settled for this period | [optional] 
**Consumed** | **int?** | The partial plan amount consumed up to date for this period | [optional] 
**Remaining** | **int?** | The partial plan amount remaining for this period. This amount can be refunded in the case the subscription is expired or put on hold and the amount has been paid. | [optional] 
**OnlineRefundable** | **int?** | The amount that can be online refunded on the subscription | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

