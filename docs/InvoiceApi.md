# IO.Swagger.Api.InvoiceApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelAllDunningPending**](InvoiceApi.md#cancelalldunningpending) | **POST** /v1/invoice/cancel_all_dunning_pending/subscription/{handle} | Cancel all dunning and pending
[**CancelInvoice**](InvoiceApi.md#cancelinvoice) | **POST** /v1/invoice/{id}/cancel | Cancel invoice
[**GetInvoice**](InvoiceApi.md#getinvoice) | **GET** /v1/invoice/{id} | Get invoice
[**GetInvoices**](InvoiceApi.md#getinvoices) | **GET** /v1/invoice | Get list of invoices
[**ManualSettle**](InvoiceApi.md#manualsettle) | **POST** /v1/invoice/{id}/manual_settle | Manual settle
[**ReactivateInvoice**](InvoiceApi.md#reactivateinvoice) | **POST** /v1/invoice/{id}/reactivate | Reactivate invoice
[**Refund**](InvoiceApi.md#refund) | **POST** /v1/invoice/{id}/refund | Refund settled invoice
[**TransactionDetails**](InvoiceApi.md#transactiondetails) | **GET** /v1/invoice/{id}/card_transaction/{transaction}/details | Get card transaction details


<a name="cancelalldunningpending"></a>
# **CancelAllDunningPending**
> List<Invoice> CancelAllDunningPending (string handle)

Cancel all dunning and pending



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelAllDunningPendingExample
    {
        public void main()
        {
            
            var apiInstance = new InvoiceApi();
            var handle = handle_example;  // string | Subscriptiom handle

            try
            {
                // Cancel all dunning and pending
                List&lt;Invoice&gt; result = apiInstance.CancelAllDunningPending(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.CancelAllDunningPending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Subscriptiom handle | 

### Return type

[**List<Invoice>**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelinvoice"></a>
# **CancelInvoice**
> Invoice CancelInvoice (string id)

Cancel invoice



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | Invoice id

            try
            {
                // Cancel invoice
                Invoice result = apiInstance.CancelInvoice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.CancelInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Invoice id | 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoice"></a>
# **GetInvoice**
> Invoice GetInvoice (string id)

Get invoice



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | Invoice id

            try
            {
                // Get invoice
                Invoice result = apiInstance.GetInvoice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.GetInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Invoice id | 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoices"></a>
# **GetInvoices**
> InvoiceSearch GetInvoices (int? page = null, int? size = null, string search = null, string sort = null)

Get list of invoices



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public void main()
        {
            
            var apiInstance = new InvoiceApi();
            var page = 1;  // int? | Page number to get (optional)  (default to 1)
            var size = 56;  // int? | Page size to use (optional)  (default to 20)
            var search = search_example;  // string | Optional search expression (optional) 
            var sort = sort_example;  // string | Optional sorting expression (optional) 

            try
            {
                // Get list of invoices
                InvoiceSearch result = apiInstance.GetInvoices(page, size, search, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.GetInvoices: " + e.Message );
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

[**InvoiceSearch**](InvoiceSearch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="manualsettle"></a>
# **ManualSettle**
> Invoice ManualSettle (string id, ManualSettleTransfer body = null)

Manual settle



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ManualSettleExample
    {
        public void main()
        {
            
            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | Invoice id
            var body = new ManualSettleTransfer(); // ManualSettleTransfer |  (optional) 

            try
            {
                // Manual settle
                Invoice result = apiInstance.ManualSettle(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.ManualSettle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Invoice id | 
 **body** | [**ManualSettleTransfer**](ManualSettleTransfer.md)|  | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactivateinvoice"></a>
# **ReactivateInvoice**
> Invoice ReactivateInvoice (string id)

Reactivate invoice



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReactivateInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | Invoice id

            try
            {
                // Reactivate invoice
                Invoice result = apiInstance.ReactivateInvoice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.ReactivateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Invoice id | 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refund"></a>
# **Refund**
> Invoice Refund (string id, RefundInvoice body = null)

Refund settled invoice



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RefundExample
    {
        public void main()
        {
            
            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | Invoice id
            var body = new RefundInvoice(); // RefundInvoice |  (optional) 

            try
            {
                // Refund settled invoice
                Invoice result = apiInstance.Refund(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.Refund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Invoice id | 
 **body** | [**RefundInvoice**](RefundInvoice.md)|  | [optional] 

### Return type

[**Invoice**](Invoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactiondetails"></a>
# **TransactionDetails**
> Dictionary<string, Object> TransactionDetails (string id, string transaction)

Get card transaction details



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransactionDetailsExample
    {
        public void main()
        {
            
            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | Invoice id
            var transaction = transaction_example;  // string | Transaction id

            try
            {
                // Get card transaction details
                Dictionary&lt;string, Object&gt; result = apiInstance.TransactionDetails(id, transaction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.TransactionDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Invoice id | 
 **transaction** | **string**| Transaction id | 

### Return type

**Dictionary<string, Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

