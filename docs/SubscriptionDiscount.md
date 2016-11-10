# IO.Swagger.Model.SubscriptionDiscount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Handle** | **string** | Per subscription unique handle for the subscription discount. | 
**Discount** | **string** | Discount for subscription discount | 
**State** | **string** | Discount state &#x60;active&#x60; or &#x60;disabled&#x60;. | 
**Coupon** | **string** | Coupon reference if this discount was released by a coupon code | [optional] 
**Deleted** | **DateTime?** | Date when the discount was deleted if deleted. In ISO-8601 extended offset date-time format. | [optional] 
**Created** | **DateTime?** | Date when the discount was created. In ISO-8601 extended offset date-time format. | 
**Name** | **string** | Name of discount. Will be used as order line text. | 
**Description** | **string** | Optional description of discount | [optional] 
**Amount** | **int?** | Fixed amount discount deducted from order line amounts including VAT | [optional] 
**Percentage** | **int?** | Percentage discount applied to each applicable order line | [optional] 
**Count** | **int?** | Number of invoices this subscription discount has been applied to | 
**Invoices** | **List&lt;string&gt;** | List of invoices this subscription discount has been applied to | 
**ApplyTo** | **List&lt;string&gt;** | Which order lines the discount is applicable to: &#x60;all&#x60;, &#x60;setup_fee&#x60;, &#x60;plan&#x60;, &#x60;additional_cost&#x60;, &#x60;add_on&#x60; and &#x60;ondemand&#x60; | 
**FixedCount** | **int?** | Apply discount to a fixed number of invoices | [optional] 
**FixedPeriodUnit** | **string** | Time unit use for fixed valid period | [optional] 
**FixedPeriod** | **int?** | Fixed period length e.g. 12 months or 14 days | [optional] 
**FixedUsageReached** | **bool?** | Whether fixed usage for subscription discount has been reached | [default to false]
**FixedPeriodPassed** | **bool?** | Whether fixed period for subscription discount has been passed | [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

