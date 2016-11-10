# IO.Swagger.Model.UpdateSubscriptionPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the plan | 
**Description** | **string** | Description of the plan | [optional] 
**Vat** | **float?** | Optional vat for this plan. Account default is used if none given. | [optional] 
**DunningPlan** | **string** | Dunning plan handle | [optional] 
**RenewalReminderEmailDays** | **int?** | Optional renewal reminder email settings. Number of days before next billing to send a reminder email. | [optional] 
**TrialReminderEmailDays** | **int?** | Optional end of trial reminder email settings. Number of days before end of trial to send a reminder email. | [optional] 
**PartialPeriodHandling** | **string** | How to handle a potential initial partial billing period for fixed day scheduling. The options are to bill for a full period, bill prorated for the partial period, bill a zero amoumt, or not to consider the period before first fixed day a billing period. The default is to bill prorated. Options: &#x60;bill_full&#x60;, &#x60;bill_prorated&#x60;, &#x60;bill_zero_amount&#x60;, &#x60;no_bill&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

