# IO.Swagger.Model.Subscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Handle** | **string** | Per account unique handle for subscription | 
**Customer** | **string** | Customer handle | 
**Plan** | **string** | Subscription plan handle | 
**State** | **string** | State of the subscription, one of the following: &#x60;active&#x60;, &#x60;expired&#x60; or &#x60;on_hold&#x60;. Active subscriptions can be cancelled and will expire at the end of the current billing period, or later depending on optional notice and fixation periods, this can be checked using the &#x60;is_cancelled&#x60; parameter and &#x60;expires&#x60;. | 
**Test** | **bool?** | Test flag | [default to false]
**Amount** | **int?** | Optional custom plan price. If defined the plan price billed for each billing period will be overridden by this price. | [optional] 
**Quantity** | **int?** | Quantity of the plan product for this subscription. | 
**Expires** | **DateTime?** | Fixed date when the subscription will expire because of cancellation. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**Reactivated** | **DateTime?** | Date when the subscription was reactivated from on hold. [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**Timezone** | **string** | Time zone for the subscription as standard time zone id. See [Wikipedia](http://en.wikipedia.org/wiki/List_of_tz_database_time_zones) | 
**Created** | **DateTime?** | Date when the subscription was created. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**Renewing** | **bool?** | If the subscription renews at current period end. Also true for subscriptions with manual scheduling. | [default to false]
**PlanVersion** | **int?** | Subscription plan version | 
**AmountInclVat** | **bool?** | If optional custom plan price this paramtere tells whether the amount is including VAT | [optional] [default to false]
**StartDate** | **DateTime?** | Date and time from which the subscription is eligiable to schedule invoices. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**EndDate** | **DateTime?** | Fixed end date and time. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**GraceDuration** | **long?** | Grace duration in seconds from the creation of a subscription where no dunning process is started for a failing invoice. This allows a certain amount of time for the customer to sign up with a payment method. | [optional] 
**CurrentPeriodStart** | **DateTime?** | Start date and time for the current billing period. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**NextPeriodStart** | **DateTime?** | Start date and time for the next billing period, and also end date and time for the current billing period. Is also the date and time for next invoice if the subscription is renewing. In ISO-8601 extended offset date-time format. | [optional] 
**FirstPeriodStart** | **DateTime?** | Start date and time for the first ever billing period. In ISO-8601 extended offset date-time format. | [optional] 
**LastPeriodStart** | **DateTime?** | Start date and time for the previous billing period. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**TrialStart** | **DateTime?** | Start date and time of free trial period. In ISO-8601 extended offset date-time format. | [optional] 
**TrialEnd** | **DateTime?** | End date and time of free trial period. In ISO-8601 extended offset date-time format. | [optional] 
**IsCancelled** | **bool?** | Whether the subscription has been cancelled. Cancelled subscriptions will expire at the end of the current billing period. | [default to false]
**InTrial** | **bool?** | Whether the susbcription is in its trial period. If subscription has not started (has_started), trial_start and trial_end can be used to determine if the subscription will have a trial period. | [default to false]
**HasStarted** | **bool?** | If subscription has a later start date, this parameter tells if the subscription has started. Use this in connection with state to determine if a subscription is active. | [default to false]
**RenewalCount** | **int?** | Number of renewals for the subscription (number of invoices) | 
**CancelledDate** | **DateTime?** | Date when the subscription was cancelled. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**ExpiredDate** | **DateTime?** | Date when the subscription expired. [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**ExpireReason** | **string** | Reason for expire. Can be &#x60;ondemand&#x60;, &#x60;cancelled&#x60;, &#x60;dunning&#x60; or &#x60;fixed&#x60;  | [optional] 
**OnHoldDate** | **DateTime?** | Date when the subscription was put on hold. [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | [optional] 
**OnHoldReason** | **string** | Reason for on hold. Can be &#x60;ondemand&#x60; or &#x60;dunning&#x60;  | [optional] 
**PaymentMethodAdded** | **bool?** | Whether the customer at some point has added payment information to the subscription | [default to false]
**ScheduledPlanChange** | **string** | If set, a subscription plan change has been scheduled to follow the next renewal. The value is the subscription plan handle to update to. | [optional] 
**ReminderEmailSent** | **DateTime?** | If defined the date a reminder email was sent for the current billing period. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. | 
**FailedInvoices** | **int?** | Number of failed invoices for this subscription | 
**FailedAmount** | **int?** | Summed amount for failed invoices | 
**CancelledInvoices** | **int?** | Number of cancelled invoices for this subscription | 
**CancelledAmount** | **int?** | Summed amount for cancelled invoices | 
**PendingInvoices** | **int?** | Number of pending invoices for this subscription | 
**PendingAmount** | **int?** | Summed amount for pending invoices | 
**DunningInvoices** | **int?** | Number of dunning invoices for this subscription | 
**DunningAmount** | **int?** | Summed amount for dunning invoices | 
**SettledInvoices** | **int?** | Number of settled invoices for this subscription | 
**SettledAmount** | **int?** | Summed settled amount | 
**RefundedAmount** | **int?** | Summed refunded amount | 
**PendingAdditionalCosts** | **int?** | Number of pending additional costs | 
**PendingAdditionalCostAmount** | **int?** | Summed amount of pending additional costs incl vat | 
**TransferredAdditionalCosts** | **int?** | Number of additional costs that have been applied to invoices | 
**TransferredAdditionalCostAmount** | **int?** | Summed amount of additional costs that have been applied to invoices | 
**PendingCredits** | **int?** | Number of credits that have not fully been applied to invoices | 
**PendingCreditAmount** | **int?** | Summed credit amount not yet applied to invoices | 
**TransferredCredits** | **int?** | Number of credits that have fully been applied to invoices | 
**TransferredCreditAmount** | **int?** | Summed credit amount that have been applied to invoices | 
**HostedPageLinks** | [**SubscriptionLinks**](SubscriptionLinks.md) | Links to hosted pages relating to subscription | 
**SubscriptionDiscounts** | **List&lt;string&gt;** | List of susbcription discounts handles attached to subscription | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

