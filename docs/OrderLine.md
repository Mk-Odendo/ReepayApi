# IO.Swagger.Model.OrderLine
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Per account unique order line id | 
**Ordertext** | **string** | Order line text | 
**Amount** | **int?** | Order line total amount including vat | 
**Vat** | **float?** | Order line vat percent | 
**Quantity** | **int?** | Order line quantity | 
**Origin** | **string** | Order line origin, one of the following: &#x60;plan&#x60;, &#x60;ondemand&#x60;, &#x60;additional_cost&#x60;, &#x60;credit&#x60;, &#x60;discount&#x60; | 
**Timestamp** | **DateTime?** | Timestamp from order line origin, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**DiscountedAmount** | **int?** | Order line amount after potential discount has been deducted | [optional] 
**AmountVat** | **int?** | Order line total vat amount | 
**AmountExVat** | **int?** | Order line total amount without vat | 
**UnitAmount** | **int?** | Order line unit amount including vat | 
**UnitAmountVat** | **int?** | Order line unit vat amount | 
**UnitAmountExVat** | **int?** | Order line unit amount without vat | 
**AmountDefinedInclVat** | **bool?** | Whether the amount was defined including VAT. E.g. plan amount defined including VAT. | [default to false]
**OriginHandle** | **string** | Handle for additional cost, credit, plan or subscription discount in the case one of those are the origin | [optional] 
**PeriodFrom** | **DateTime?** | The start of billing period if the order line is a plan order line for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**PeriodTo** | **DateTime?** | The end of billing period if the order line is a plan order line for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**DiscountPercentage** | **int?** | The discount percentage for discount order lines that has a percentage discount | [optional] 
**DiscountedOrderLine** | **string** | For discount order lines a reference to the order line for which the order line is a discount | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

