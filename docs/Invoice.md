# IO.Swagger.Model.Invoice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Invoice id assigned by Reepay | 
**Customer** | **string** | Customer handle | 
**Subscription** | **string** | Subscription handle, will be null for a one-time customer invoice | [optional] 
**Plan** | **string** | Subscription plan handle for the plan used to automatically create the invoice. Will be null for one-time invoices. | [optional] 
**State** | **string** | The invoice state one of the following: &#x60;pending&#x60;, &#x60;dunning&#x60;, &#x60;settled&#x60;, &#x60;cancelled&#x60;, &#x60;failed&#x60; | 
**Amount** | **int?** | The invoice amount including VAT | 
**Number** | **int?** | Sequential invoice number | 
**Currency** | **string** | Currency for the account in [ISO 4217](http://da.wikipedia.org/wiki/ISO_4217) three letter alpha code | 
**Due** | **DateTime?** | When is the invoice due, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Failed** | **DateTime?** | When the invoice failed, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**Settled** | **DateTime?** | When the invoice settled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**Cancelled** | **DateTime?** | When the invoice was cancelled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**Credits** | [**List&lt;CreditInvoice&gt;**](CreditInvoice.md) | Credits applied to invoice | 
**Adjustments** | [**List&lt;InvoiceAdjustment&gt;**](InvoiceAdjustment.md) | Invoice adjustments | [optional] 
**Created** | **DateTime?** | When the invoice was created, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**PlanVersion** | **int?** | Subscription plan version | [optional] 
**DunningPlan** | **string** | Dunning plan handle | [optional] 
**DiscountAmount** | **int?** | The potential discount amount deducted from the invoice amount including VAT | 
**OrgAmount** | **int?** | The invoice original amount including VAT, may differ from amount if adjustments have been applied for the invoice | 
**AmountVat** | **int?** | The invoice vat amount calculated as rounded summed fractional vats for each orderline | 
**AmountExVat** | **int?** | The invoice amount without vat | 
**SettledAmount** | **int?** | Settled amount | 
**RefundedAmount** | **int?** | Refunded amount | 
**PeriodNumber** | **int?** | The subscription period this invoice is for | [optional] 
**OrderLines** | [**List&lt;OrderLine&gt;**](OrderLine.md) | Order lines for invoice sorted by descending timestamp | 
**AdditionalCosts** | **List&lt;string&gt;** | Additional costs for invoice | 
**CardTransactions** | [**List&lt;CardTransaction&gt;**](CardTransaction.md) | Invoice card transactions | 
**ManualTransactions** | [**List&lt;ManualTransaction&gt;**](ManualTransaction.md) | Invoice manual transactions | 
**CreditNotes** | [**List&lt;InvoiceCreditNote&gt;**](InvoiceCreditNote.md) | Invoice credit notes | [optional] 
**DunningStart** | **DateTime?** | When dunning for the invoice was started, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**DunningCount** | **int?** | Number of dunning events for invoice (number of reminders sent) | [optional] 
**DunningExpired** | **DateTime?** | When dunning for the invoice expired, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**PeriodFrom** | **DateTime?** | The start of billing period if the invoice is for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**PeriodTo** | **DateTime?** | The end of billing period if the invoice is for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

