# IO.Swagger.Model.Card
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique id for payment method | 
**State** | **string** | State of the payment method: &#x60;active&#x60;, &#x60;inactivated&#x60; or &#x60;failed&#x60; | 
**Customer** | **string** | Customer by handle | 
**Failed** | **DateTime?** | Date when the payment method failed. In ISO-8601 extended offset date-time format. | [optional] 
**Created** | **DateTime?** | Date when the payment method was created. In ISO-8601 extended offset date-time format. | 
**GwRef** | **string** | Card gateway reference id | 
**CardType** | **string** | Card type | 
**ExpDate** | **string** | Card expire date on form MM-YY  | [optional] 
**MaskedCard** | **string** | Masked card number | [optional] 
**LastSuccess** | **DateTime?** | Date and time of last succesfull use of the card. In ISO-8601 extended offset date-time format. | [optional] 
**LastFailed** | **DateTime?** | Date and time of last failed use of the card. In ISO-8601 extended offset date-time format. | [optional] 
**FirstFail** | **DateTime?** | Date and time of first succesfull use of the card. In ISO-8601 extended offset date-time format. | [optional] 
**ErrorCode** | **string** | An error code from the last failed use of the card | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

