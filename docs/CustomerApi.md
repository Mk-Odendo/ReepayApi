# IO.Swagger.Api.CustomerApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivatePaymentMethod**](CustomerApi.md#activatepaymentmethod) | **POST** /v1/customer/{handle}/payment_method/{method_id}/activate | Activate payment method
[**AddCardJson**](CustomerApi.md#addcardjson) | **POST** /v1/customer/{handle}/payment_method/card | Add card payment method
[**CreateCustomerInvoice**](CustomerApi.md#createcustomerinvoice) | **POST** /v1/customer/{handle}/invoice | Create invoice ondemand for customer
[**CreateCustomerJson**](CustomerApi.md#createcustomerjson) | **POST** /v1/customer | Create customer
[**CreateCustomerNoteJson**](CustomerApi.md#createcustomernotejson) | **POST** /v1/customer/{handle}/note | Create customer note
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /v1/customer/{handle} | Delete customer
[**GetCard**](CustomerApi.md#getcard) | **GET** /v1/customer/{handle}/payment_method/card/{id} | Get card
[**GetCardDetails**](CustomerApi.md#getcarddetails) | **GET** /v1/customer/{handle}/payment_method/card/{id}/details | Get gateway card details
[**GetCustomer**](CustomerApi.md#getcustomer) | **GET** /v1/customer/{handle} | Get customer
[**GetCustomerNotes**](CustomerApi.md#getcustomernotes) | **GET** /v1/customer/{handle}/note | Get customer notes
[**GetCustomerPaymentMethods**](CustomerApi.md#getcustomerpaymentmethods) | **GET** /v1/customer/{handle}/payment_method | Get payment methods
[**GetCustomers**](CustomerApi.md#getcustomers) | **GET** /v1/customer | Get list of customers
[**ImportCardJson**](CustomerApi.md#importcardjson) | **POST** /v1/customer/{handle}/payment_method/card_import | Import card payment method
[**InactivatePaymentMethod**](CustomerApi.md#inactivatepaymentmethod) | **POST** /v1/customer/{handle}/payment_method/{method_id}/inactivate | Inactivate payment method
[**UpdateCustomerJson**](CustomerApi.md#updatecustomerjson) | **PUT** /v1/customer/{handle} | Update customer


<a name="activatepaymentmethod"></a>
# **ActivatePaymentMethod**
> PaymentMethods ActivatePaymentMethod (string handle, string methodId)

Activate payment method



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActivatePaymentMethodExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle
            var methodId = methodId_example;  // string | Payment method id

            try
            {
                // Activate payment method
                PaymentMethods result = apiInstance.ActivatePaymentMethod(handle, methodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ActivatePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 
 **methodId** | **string**| Payment method id | 

### Return type

[**PaymentMethods**](PaymentMethods.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcardjson"></a>
# **AddCardJson**
> Card AddCardJson (string handle, CardToken body = null)

Add card payment method



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddCardJsonExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle
            var body = new CardToken(); // CardToken |  (optional) 

            try
            {
                // Add card payment method
                Card result = apiInstance.AddCardJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.AddCardJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 
 **body** | [**CardToken**](CardToken.md)|  | [optional] 

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomerinvoice"></a>
# **CreateCustomerInvoice**
> Invoice CreateCustomerInvoice (string handle, CreateCustomerInvoice body = null)

Create invoice ondemand for customer



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomerInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle
            var body = new CreateCustomerInvoice(); // CreateCustomerInvoice |  (optional) 

            try
            {
                // Create invoice ondemand for customer
                Invoice result = apiInstance.CreateCustomerInvoice(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CreateCustomerInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 
 **body** | [**CreateCustomerInvoice**](CreateCustomerInvoice.md)|  | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomerjson"></a>
# **CreateCustomerJson**
> Customer CreateCustomerJson (CreateCustomer body = null)

Create customer



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomerJsonExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var body = new CreateCustomer(); // CreateCustomer |  (optional) 

            try
            {
                // Create customer
                Customer result = apiInstance.CreateCustomerJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CreateCustomerJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCustomer**](CreateCustomer.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomernotejson"></a>
# **CreateCustomerNoteJson**
> CustomerNote CreateCustomerNoteJson (string handle, CreateCustomerNote body = null)

Create customer note



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCustomerNoteJsonExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | 
            var body = new CreateCustomerNote(); // CreateCustomerNote |  (optional) 

            try
            {
                // Create customer note
                CustomerNote result = apiInstance.CreateCustomerNoteJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.CreateCustomerNoteJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**|  | 
 **body** | [**CreateCustomerNote**](CreateCustomerNote.md)|  | [optional] 

### Return type

[**CustomerNote**](CustomerNote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomer"></a>
# **DeleteCustomer**
> Customer DeleteCustomer (string handle)

Delete customer



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle

            try
            {
                // Delete customer
                Customer result = apiInstance.DeleteCustomer(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.DeleteCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcard"></a>
# **GetCard**
> Card GetCard (string handle, string id)

Get card



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCardExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle
            var id = id_example;  // string | Card id

            try
            {
                // Get card
                Card result = apiInstance.GetCard(handle, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 
 **id** | **string**| Card id | 

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcarddetails"></a>
# **GetCardDetails**
> Dictionary<string, Object> GetCardDetails (string handle, string id)

Get gateway card details



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCardDetailsExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle
            var id = id_example;  // string | Card id

            try
            {
                // Get gateway card details
                Dictionary&lt;string, Object&gt; result = apiInstance.GetCardDetails(handle, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCardDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 
 **id** | **string**| Card id | 

### Return type

**Dictionary<string, Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomer"></a>
# **GetCustomer**
> Customer GetCustomer (string handle)

Get customer



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomerExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle

            try
            {
                // Get customer
                Customer result = apiInstance.GetCustomer(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomernotes"></a>
# **GetCustomerNotes**
> List<CustomerNote> GetCustomerNotes (string handle)

Get customer notes



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomerNotesExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle

            try
            {
                // Get customer notes
                List&lt;CustomerNote&gt; result = apiInstance.GetCustomerNotes(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomerNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 

### Return type

[**List<CustomerNote>**](CustomerNote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerpaymentmethods"></a>
# **GetCustomerPaymentMethods**
> PaymentMethods GetCustomerPaymentMethods (string handle)

Get payment methods



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomerPaymentMethodsExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle

            try
            {
                // Get payment methods
                PaymentMethods result = apiInstance.GetCustomerPaymentMethods(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomerPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 

### Return type

[**PaymentMethods**](PaymentMethods.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomers"></a>
# **GetCustomers**
> CustomerSearch GetCustomers (int? page = null, int? size = null, string search = null, string sort = null)

Get list of customers



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCustomersExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var page = 1;  // int? | Page number to get (optional)  (default to 1)
            var size = 56;  // int? | Page size to use (optional)  (default to 20)
            var search = search_example;  // string | Optional search expression (optional) 
            var sort = sort_example;  // string | Optional sorting expression (optional) 

            try
            {
                // Get list of customers
                CustomerSearch result = apiInstance.GetCustomers(page, size, search, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to get | [optional] [default to 1]
 **size** | **int?**| Page size to use | [optional] [default to 20]
 **search** | **string**| Optional search expression | [optional] 
 **sort** | **string**| Optional sorting expression | [optional] 

### Return type

[**CustomerSearch**](CustomerSearch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importcardjson"></a>
# **ImportCardJson**
> Card ImportCardJson (string handle, CardImport body = null)

Import card payment method



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportCardJsonExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle
            var body = new CardImport(); // CardImport |  (optional) 

            try
            {
                // Import card payment method
                Card result = apiInstance.ImportCardJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ImportCardJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 
 **body** | [**CardImport**](CardImport.md)|  | [optional] 

### Return type

[**Card**](Card.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inactivatepaymentmethod"></a>
# **InactivatePaymentMethod**
> PaymentMethods InactivatePaymentMethod (string handle, string methodId)

Inactivate payment method



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InactivatePaymentMethodExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle
            var methodId = methodId_example;  // string | Payment method id

            try
            {
                // Inactivate payment method
                PaymentMethods result = apiInstance.InactivatePaymentMethod(handle, methodId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.InactivatePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 
 **methodId** | **string**| Payment method id | 

### Return type

[**PaymentMethods**](PaymentMethods.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerjson"></a>
# **UpdateCustomerJson**
> Customer UpdateCustomerJson (string handle, UpdateCustomer body = null)

Update customer



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCustomerJsonExample
    {
        public void main()
        {
            
            var apiInstance = new CustomerApi();
            var handle = handle_example;  // string | Customer handle
            var body = new UpdateCustomer(); // UpdateCustomer |  (optional) 

            try
            {
                // Update customer
                Customer result = apiInstance.UpdateCustomerJson(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.UpdateCustomerJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Customer handle | 
 **body** | [**UpdateCustomer**](UpdateCustomer.md)|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

