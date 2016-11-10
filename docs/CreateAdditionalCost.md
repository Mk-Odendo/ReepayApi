# IO.Swagger.Model.CreateAdditionalCost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subscription** | **string** | Subscription handle | 
**Handle** | **string** | Per account unique handle for the additional cost | 
**Ordertext** | **string** | Order text for the additional cost. Will be on affected invoices. | 
**Quantity** | **int?** | Quantity for the additional cost. Default 1. | [optional] 
**Amount** | **int?** | Per quantity amount in the smallest unit for the account currency | 
**Vat** | **float?** | Optional vat for additional cost. Account default is used if none given. | [optional] 
**AmountInclVat** | **bool?** | Whether the per quantity amount is including VAT. Defaults to true. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

