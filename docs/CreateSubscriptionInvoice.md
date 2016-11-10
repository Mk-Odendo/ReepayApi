# IO.Swagger.Model.CreateSubscriptionInvoice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_Ref** | **string** | Optional reference to avoid double creations. Only one invoice can be created per reference. | [optional] 
**Instant** | **bool?** | Create and process transaction instantly and only create invoice for successful transaction (default false) | [optional] [default to false]
**Due** | **string** | Optional due date and time on the form yyyy-MM-dd, yyyyMMdd, yyyy-MM-ddTHH:mm and yyyy-MM-ddTHH:mm:ss from which the invoice is eligible to be collected | [optional] 
**PlanManual** | **bool?** | Create manually for plan by adding plan product as orderline (default false) | [optional] [default to false]
**CollectAdditionalCosts** | **bool?** | Collect pending additional costs and transfer to invoice (default true) | [optional] [default to false]
**CollectCredit** | **bool?** | Collect pending credit and transfer to invoice (default true) | [optional] [default to false]
**ApplyDiscounts** | **bool?** | Apply potential discounts for the subscription to the invoice order lines (default true) | [optional] [default to false]
**OrderLines** | [**List&lt;CreateOrderLine&gt;**](CreateOrderLine.md) | Optional orderlines for the invoice | [optional] 
**ManualTransfer** | [**ManualSettleTransfer**](ManualSettleTransfer.md) | Optional manual tranfer. If given the invoice will be settled using the manual transfer transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

