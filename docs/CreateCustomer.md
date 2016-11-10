# IO.Swagger.Model.CreateCustomer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Customer email | [optional] 
**Address** | **string** | Customer address | [optional] 
**Address2** | **string** | Customer address2 | [optional] 
**City** | **string** | Customer city | [optional] 
**Country** | **string** | Customer country in ISO 3166-1 alpha-2 | [optional] 
**Phone** | **string** | Customer phone number | [optional] 
**Company** | **string** | Customer company | [optional] 
**Vat** | **string** | Customer vat number | [optional] 
**Handle** | **string** | Per account unique handle for the customer. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. Must be provided if generate_handle is not defined. | 
**Test** | **bool?** | Test flag. If given it will be verified that the account state matches the intended create state. | [optional] [default to false]
**FirstName** | **string** | Customer first name | [optional] 
**LastName** | **string** | Customer last name | [optional] 
**PostalCode** | **string** | Customer postal code | [optional] 
**GenerateHandle** | **bool?** | Auto generate handle on the form cust-[sequence_number] | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

