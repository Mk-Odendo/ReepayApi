# IO.Swagger.Model.Coupon
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Handle** | **string** | Per account unique handle for the coupon | 
**Code** | **string** | The coupon code. Maximum 100 characters. | 
**Discount** | **string** | Discount to use for coupon | 
**Name** | **string** | Internal name for the coupon. | 
**State** | **string** | Coupon state &#x60;active&#x60;, &#x60;expired&#x60;, &#x60;deleted&#x60; or &#x60;generating&#x60; | 
**Type** | **string** | Coupon type either &#x60;single&#x60; or &#x60;set&#x60; | 
**Redemptions** | **int?** | Number of times the coupon has been redeemed | 
**Expired** | **DateTime?** | Date and time for expire if state expired. In ISO-8601 extended offset date-time format. | [optional] 
**Created** | **DateTime?** | Date when the coupon was created. In ISO-8601 extended offset date-time format. | 
**AllPlans** | **bool?** | Whether all plans are eligible for this coupon. Defaults to false. | [optional] [default to false]
**EligiblePlans** | **List&lt;string&gt;** | If not all_plans are set to true, then the set of eligible plan handles must be defined. | [optional] 
**MaxRedemptions** | **int?** | Optional maximum number of times this coupon can be redeemed. | [optional] 
**ValidUntil** | **DateTime?** | Optional date and time until which the coupon is redeemable. In ISO-8601 extended offset date-time format. | [optional] 
**ExpireReason** | **string** | The expire reason if expired. One of &#x60;early&#x60;, &#x60;valid_until&#x60; or &#x60;max&#x60;. Respectively on demand early expire, valid until has passed or max redemptions has been reached. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

