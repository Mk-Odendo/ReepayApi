# IO.Swagger.Model.CreateCredit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subscription** | **string** | Subscription by handle to add the credit to | 
**Handle** | **string** | Per account unique handle for the credit. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. | 
**Amount** | **int?** | Credit amount in the smallest unit for the account currency | 
**Text** | **string** | Text describing the credit. Will be on affected invoices. | 
**ValidFrom** | **string** | Date on the form yyyy-MM-dd from which the credit is valid. The credit will not be deducted from invoices before this date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

