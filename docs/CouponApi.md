# IO.Swagger.Api.CouponApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCoupon**](CouponApi.md#createcoupon) | **POST** /v1/coupon | Create coupon
[**DeleteCoupon**](CouponApi.md#deletecoupon) | **DELETE** /v1/coupon/{handle} | Delete coupon
[**ExpireCoupon**](CouponApi.md#expirecoupon) | **POST** /v1/coupon/{handle}/expire | Expire coupon
[**GetCoupon**](CouponApi.md#getcoupon) | **GET** /v1/coupon/{handle} | Get coupon
[**GetCoupons**](CouponApi.md#getcoupons) | **GET** /v1/coupon | Get list of coupons
[**UpdateCoupon**](CouponApi.md#updatecoupon) | **PUT** /v1/coupon/{handle} | Update coupon
[**ValidateCode**](CouponApi.md#validatecode) | **GET** /v1/coupon/code/validate | Validate coupon


<a name="createcoupon"></a>
# **CreateCoupon**
> Coupon CreateCoupon (CreateCoupon body = null)

Create coupon



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCouponExample
    {
        public void main()
        {
            
            var apiInstance = new CouponApi();
            var body = new CreateCoupon(); // CreateCoupon |  (optional) 

            try
            {
                // Create coupon
                Coupon result = apiInstance.CreateCoupon(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.CreateCoupon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCoupon**](CreateCoupon.md)|  | [optional] 

### Return type

[**Coupon**](Coupon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecoupon"></a>
# **DeleteCoupon**
> Coupon DeleteCoupon (string handle)

Delete coupon



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCouponExample
    {
        public void main()
        {
            
            var apiInstance = new CouponApi();
            var handle = handle_example;  // string | Coupon handle

            try
            {
                // Delete coupon
                Coupon result = apiInstance.DeleteCoupon(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.DeleteCoupon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Coupon handle | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expirecoupon"></a>
# **ExpireCoupon**
> Coupon ExpireCoupon (string handle)

Expire coupon



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpireCouponExample
    {
        public void main()
        {
            
            var apiInstance = new CouponApi();
            var handle = handle_example;  // string | Coupon handle

            try
            {
                // Expire coupon
                Coupon result = apiInstance.ExpireCoupon(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.ExpireCoupon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Coupon handle | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoupon"></a>
# **GetCoupon**
> Coupon GetCoupon (string handle)

Get coupon



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCouponExample
    {
        public void main()
        {
            
            var apiInstance = new CouponApi();
            var handle = handle_example;  // string | Coupon handle

            try
            {
                // Get coupon
                Coupon result = apiInstance.GetCoupon(handle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GetCoupon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Coupon handle | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoupons"></a>
# **GetCoupons**
> CouponSearch GetCoupons (int? page, int? size, string search, string sort)

Get list of coupons



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCouponsExample
    {
        public void main()
        {
            
            var apiInstance = new CouponApi();
            var page = 1;  // int? | Page number to get (default to 1)
            var size = 56;  // int? | Page size to use (default to 20)
            var search = search_example;  // string | Optional search expression
            var sort = sort_example;  // string | Optional sorting expression

            try
            {
                // Get list of coupons
                CouponSearch result = apiInstance.GetCoupons(page, size, search, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.GetCoupons: " + e.Message );
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

[**CouponSearch**](CouponSearch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecoupon"></a>
# **UpdateCoupon**
> Coupon UpdateCoupon (string handle, UpdateCoupon body = null)

Update coupon



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCouponExample
    {
        public void main()
        {
            
            var apiInstance = new CouponApi();
            var handle = handle_example;  // string | Coupon handle
            var body = new UpdateCoupon(); // UpdateCoupon |  (optional) 

            try
            {
                // Update coupon
                Coupon result = apiInstance.UpdateCoupon(handle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.UpdateCoupon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **handle** | **string**| Coupon handle | 
 **body** | [**UpdateCoupon**](UpdateCoupon.md)|  | [optional] 

### Return type

[**Coupon**](Coupon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatecode"></a>
# **ValidateCode**
> Coupon ValidateCode (string code, string plan = null, string customer = null)

Validate coupon



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidateCodeExample
    {
        public void main()
        {
            
            var apiInstance = new CouponApi();
            var code = code_example;  // string | Coupon code
            var plan = plan_example;  // string | Optional plan to validate against (optional) 
            var customer = customer_example;  // string | Optional customer to validate against (optional) 

            try
            {
                // Validate coupon
                Coupon result = apiInstance.ValidateCode(code, plan, customer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponApi.ValidateCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| Coupon code | 
 **plan** | **string**| Optional plan to validate against | [optional] 
 **customer** | **string**| Optional customer to validate against | [optional] 

### Return type

[**Coupon**](Coupon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

