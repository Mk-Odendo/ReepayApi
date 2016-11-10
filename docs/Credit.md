# IO.Swagger.Model.Credit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subscription** | **string** | Subscription by handle to add the credit to | 
**Handle** | **string** | Per account unique handle for the credit. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. | 
**Amount** | **int?** | Credit amount in the smallest unit for the account currency | 
**Text** | **string** | Text describing the credit. Will be on affected invoices. | 
**State** | **string** | State of the credit, one of the following: &#x60;pending&#x60;, &#x60;transferred&#x60;, &#x60;cancelled&#x60;. Pending credits have not yet been transferred fully to invoices. Cancelled credits have been manually cancelled. | 
**Created** | **DateTime?** | Date when the credit was created. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**ValidFrom** | **string** | Date on the form yyyy-MM-dd from which the credit is valid. The credit will not be deducted from invoices before this date. | [optional] 
**CreditInvoices** | [**List&lt;CreditInvoice&gt;**](CreditInvoice.md) | List of invoices where the credit is applied | [optional] 
**PendingAmount** | **int?** | Remaining amount not transferred to invoices | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

