# IO.Swagger.Model.AdditionalCost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Invoice** | **string** | Invoice id for the invoice the additional cost has been assigned to | [optional] 
**State** | **string** | State of the additional cost, one of the following: &#x60;pending&#x60;, &#x60;transferred&#x60;, &#x60;cancelled&#x60;. A pending additonal cost has not yet been transferred to a invoice. Cancelled addtional costs have been cancelled manually. | 
**Subscription** | **string** | Subscription handle | 
**Handle** | **string** | Per account unique handle for the additional cost | 
**Ordertext** | **string** | Order text for the additional cost. Will be on affected invoices. | 
**Quantity** | **int?** | Quantity for the additional cost. Default 1. | [optional] 
**Amount** | **int?** | Additional cost total amount | 
**Vat** | **float?** | Optional vat for additional cost. Account default is used if none given. | [optional] 
**Created** | **DateTime?** | Date when the additional cost was created. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**AmountInclVat** | **bool?** | Whether the amount is including VAT. Default true. | [default to false]
**AmountVat** | **int?** | Additional cost vat amount | 
**AmountExVat** | **int?** | Additional cost amount without vat | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

