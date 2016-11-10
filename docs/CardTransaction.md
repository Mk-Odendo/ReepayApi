# IO.Swagger.Model.CardTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Transaction id assigned by Reepay | 
**State** | **string** | State of the transaction, one of the following: &#x60;pending&#x60;, &#x60;processing&#x60;, &#x60;settled&#x60;, &#x60;refunded&#x60;, &#x60;failed&#x60;, &#x60;cancelled&#x60; | 
**Invoice** | **string** | Invoice id | 
**Type** | **string** | Transaction type, one of the following: &#39;settle&#39;, &#39;refund&#39; | 
**Amount** | **int?** | The transaction amount | 
**Settled** | **DateTime?** | When the transaction was settled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Failed** | **DateTime?** | When the transaction failed, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Refunded** | **DateTime?** | When the transaction was refunded, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Created** | **DateTime?** | Date when the transaction was created. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Card** | [**Card**](Card.md) | Card used for transaction | 
**Error** | **string** | Error code if failed | [optional] 
**RefTransaction** | **string** | Id of a possible referenced transaction | [optional] 
**GwId** | **string** | Gateway id for card | [optional] 
**LastFailed** | **DateTime?** | When the card transaction last failed, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**FirstFailed** | **DateTime?** | When the card transaction first failed, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

