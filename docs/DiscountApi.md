# IO.Swagger.Api.DiscountApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDiscount**](DiscountApi.md#creatediscount) | **POST** /v1/discount | Create discount
[**DeleteDiscount**](DiscountApi.md#deletediscount) | **DELETE** /v1/discount/{handle} | Delete discount
[**GetDiscount**](DiscountApi.md#getdiscount) | **GET** /v1/discount/{handle} | Get discount
[**GetDiscounts**](DiscountApi.md#getdiscounts) | **GET** /v1/discount | Get list of discounts
[**UndeleteDiscount**](DiscountApi.md#undeletediscount) | **POST** /v1/discount/{handle}/undelete | Undelete discount


<a name="creatediscount"></a>
# **CreateDiscount**
> Discount CreateDiscount (CreateDiscount body = null)

Create discount



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDiscountExample
    {
        public void main()
        {
            
            var apiInstance = new DiscountApi();
            var body = new CreateDiscount(); // CreateDiscount |  (optional) 

            try
            {
                // Create discount
                Discount result = apiInstance.CreateDiscount(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiscountApi.CreateDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateDiscount**](CreateDiscount.md)|  | [optional] 

### Return type

[**Discount**](Discount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletediscount"></a>
# **DeleteDiscount**
> Discount DeleteDiscount (string handle)

Delete discount



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDiscountExample
    {
        public void main()
        {
            
            var apiInstance = new DiscountApi();
            var handle = handle_example;  // string | Discount handle

            try
            {
                // Delete discount
                Discount result = apiInstance.DeleteDiscount(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiscountApi.DeleteDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Discount handle | 

### Return type

[**Discount**](Discount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiscount"></a>
# **GetDiscount**
> Discount GetDiscount (string handle)

Get discount



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDiscountExample
    {
        public void main()
        {
            
            var apiInstance = new DiscountApi();
            var handle = handle_example;  // string | Discount handle

            try
            {
                // Get discount
                Discount result = apiInstance.GetDiscount(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiscountApi.GetDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Discount handle | 

### Return type

[**Discount**](Discount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiscounts"></a>
# **GetDiscounts**
> DiscountSearch GetDiscounts (int? page, int? size, string search, string sort)

Get list of discounts



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDiscountsExample
    {
        public void main()
        {
            
            var apiInstance = new DiscountApi();
            var page = 1;  // int? | Page number to get (default to 1)
            var size = 56;  // int? | Page size to use (default to 20)
            var search = search_example;  // string | Optional search expression
            var sort = sort_example;  // string | Optional sorting expression

            try
            {
                // Get list of discounts
                DiscountSearch result = apiInstance.GetDiscounts(page, size, search, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiscountApi.GetDiscounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to get | [default to 1]
 **size** | **int?**| Page size to use | [default to 20]
 **search** | **string**| Optional search expression | 
 **sort** | **string**| Optional sorting expression | 

### Return type

[**DiscountSearch**](DiscountSearch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="undeletediscount"></a>
# **UndeleteDiscount**
> Discount UndeleteDiscount (string handle)

Undelete discount



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UndeleteDiscountExample
    {
        public void main()
        {
            
            var apiInstance = new DiscountApi();
            var handle = handle_example;  // string | Discount handle

            try
            {
                // Undelete discount
                Discount result = apiInstance.UndeleteDiscount(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiscountApi.UndeleteDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Discount handle | 

### Return type

[**Discount**](Discount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

