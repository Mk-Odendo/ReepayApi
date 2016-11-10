# IO.Swagger.Model.Customer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Customer email | [optional] 
**Address** | **string** | Customer address | [optional] 
**Address2** | **string** | Customer address2 | [optional] 
**City** | **string** | Customer city | [optional] 
**Country** | **string** | Customer country in ISO 3166-1 alpha-2 | [optional] 
**Phone** | **string** | Customer phone number | [optional] 
**Company** | **string** | Customer company | [optional] 
**Vat** | **string** | Customer vat number | [optional] 
**Handle** | **string** | Per account unique handle for the customer. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. | 
**Test** | **bool?** | Test flag | [optional] [default to false]
**Subscriptions** | **int?** | Number of active subscriptions for this customer (deprecated, will be removed in a later version, use active_subscriptions) | 
**Created** | **DateTime?** | Date when the customer was created. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Deleted** | **DateTime?** | Date when the customer was deleted. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**FirstName** | **string** | Customer first name | [optional] 
**LastName** | **string** | Customer last name | [optional] 
**PostalCode** | **string** | Customer postal code | [optional] 
**ActiveSubscriptions** | **int?** | Number of active subscriptions for this customer | 
**TrialActiveSubscriptions** | **int?** | Number of active subscriptions in trial for this customer | 
**TrialCancelledSubscriptions** | **int?** | Number of cancelled subscriptions in trial for this customer | 
**ExpiredSubscriptions** | **int?** | Number of expired subscription for this customer | 
**OnHoldSubscriptions** | **int?** | Number of subscription on hold for this customer | 
**CancelledSubscriptions** | **int?** | Number of cancelled subscription for this customer | 
**NonRenewingSubscriptions** | **int?** | Number of non renewing (active subscriptions not renewing at billing period end) subscriptions for this customer | 
**FailedInvoices** | **int?** | Number of failed invoices for this customer | 
**FailedAmount** | **int?** | Summed amount for failed invoices | 
**CancelledInvoices** | **int?** | Number of cancelled invoices for this customer | 
**CancelledAmount** | **int?** | Summed amount for cancelled invoices | 
**PendingInvoices** | **int?** | Number of pending invoices for this customer | 
**PendingAmount** | **int?** | Summed amount for pending invoices | 
**DunningInvoices** | **int?** | Number of dunning invoices for this customer | 
**DunningAmount** | **int?** | Summed amount for dunning invoices | 
**SettledInvoices** | **int?** | Number of settled invoices for this customer | 
**SettledAmount** | **int?** | Summed settled amount | 
**RefundedAmount** | **int?** | Summed refunded amount | 
**PendingAdditionalCosts** | **int?** | Number of pending additional costs | 
**PendingAdditionalCostAmount** | **int?** | Summed amount of pending additional costs incl vat | 
**TransferredAdditionalCosts** | **int?** | Number of additional costs that have been applied to invoices | 
**TransferredAdditionalCostAmount** | **int?** | Summed amount of additional costs that have been applied to invoices | 
**PendingCredits** | **int?** | Number of credits that have not fully been applied to invoices | 
**PendingCreditAmount** | **int?** | Summed credit amount not yet applied to invoices | 
**TransferredCredits** | **int?** | Number of credits that have fully been applied to invoices | 
**TransferredCreditAmount** | **int?** | Summed credit amount that have been applied to invoices | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

