# IO.Swagger.Model.CreateCustomerInvoice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_Ref** | **string** | Optional reference to avoid double creations. Only one invoice can be created per reference. | [optional] 
**OrderLines** | [**List&lt;CreateOrderLine&gt;**](CreateOrderLine.md) | Orderlines for the invoice | 
**ManualTransfer** | [**ManualSettleTransfer**](ManualSettleTransfer.md) | Optional manual tranfer. If given the invoice will be settled using the manual transfer transaction. | [optional] 
**PaymentMethod** | **string** | Payment method id to use for invoice. Must be provided if no manual transfer is given. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

