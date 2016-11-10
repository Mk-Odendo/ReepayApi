# IO.Swagger.Model.ManualTransaction
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
**Method** | **string** | The method used for the offline manual transaction, allowable values: &#x60;cash&#x60;, &#x60;bank_transfer&#x60;, &#x60;check&#x60;, &#x60;chargeback&#x60;, &#x60;other&#x60; | 
**Comment** | **string** | Optional comment for manual transaction | [optional] 
**Reference** | **string** | Optional reference for the manual transaction | [optional] 
**PaymentDate** | **DateTime?** | When the manual transaction was performed on the form &#x60;yyyy-MM-dd&#x60;, &#x60;yyyyMMdd&#x60;, &#x60;yyyy-MM-ddTHH:mm&#x60; and &#x60;yyyy-MM-ddTHH:mm:ss&#x60; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

