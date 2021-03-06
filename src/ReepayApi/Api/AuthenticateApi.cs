/* 
 * Reepay API
 *
 * REST API to manage Reepay resources
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ReepayApi.Client;
using ReepayApi.Model;

namespace ReepayApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticateApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// User login
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">User email (optional)</param>
        /// <param name="password">User password (optional)</param>
        /// <param name="organisation">Organisation subdomain to login to (optional)</param>
        /// <param name="account">Account handle or id to login to (optional)</param>
        /// <returns>UserLogin</returns>
        UserLogin Login (string email = null, string password = null, string organisation = null, string account = null);

        /// <summary>
        /// User login
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">User email (optional)</param>
        /// <param name="password">User password (optional)</param>
        /// <param name="organisation">Organisation subdomain to login to (optional)</param>
        /// <param name="account">Account handle or id to login to (optional)</param>
        /// <returns>ApiResponse of UserLogin</returns>
        ApiResponse<UserLogin> LoginWithHttpInfo (string email = null, string password = null, string organisation = null, string account = null);
        /// <summary>
        /// Renew user login
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserRenew</returns>
        UserRenew Renew ();

        /// <summary>
        /// Renew user login
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserRenew</returns>
        ApiResponse<UserRenew> RenewWithHttpInfo ();
        /// <summary>
        /// Verify authentication
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void VerifyAuthentication ();

        /// <summary>
        /// Verify authentication
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> VerifyAuthenticationWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// User login
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">User email (optional)</param>
        /// <param name="password">User password (optional)</param>
        /// <param name="organisation">Organisation subdomain to login to (optional)</param>
        /// <param name="account">Account handle or id to login to (optional)</param>
        /// <returns>Task of UserLogin</returns>
        System.Threading.Tasks.Task<UserLogin> LoginAsync (string email = null, string password = null, string organisation = null, string account = null);

        /// <summary>
        /// User login
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">User email (optional)</param>
        /// <param name="password">User password (optional)</param>
        /// <param name="organisation">Organisation subdomain to login to (optional)</param>
        /// <param name="account">Account handle or id to login to (optional)</param>
        /// <returns>Task of ApiResponse (UserLogin)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserLogin>> LoginAsyncWithHttpInfo (string email = null, string password = null, string organisation = null, string account = null);
        /// <summary>
        /// Renew user login
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserRenew</returns>
        System.Threading.Tasks.Task<UserRenew> RenewAsync ();

        /// <summary>
        /// Renew user login
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserRenew)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRenew>> RenewAsyncWithHttpInfo ();
        /// <summary>
        /// Verify authentication
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task VerifyAuthenticationAsync ();

        /// <summary>
        /// Verify authentication
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VerifyAuthenticationAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticateApi : IAuthenticateApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticateApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticateApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// User login 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">User email (optional)</param>
        /// <param name="password">User password (optional)</param>
        /// <param name="organisation">Organisation subdomain to login to (optional)</param>
        /// <param name="account">Account handle or id to login to (optional)</param>
        /// <returns>UserLogin</returns>
        public UserLogin Login (string email = null, string password = null, string organisation = null, string account = null)
        {
             ApiResponse<UserLogin> localVarResponse = LoginWithHttpInfo(email, password, organisation, account);
             return localVarResponse.Data;
        }

        /// <summary>
        /// User login 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">User email (optional)</param>
        /// <param name="password">User password (optional)</param>
        /// <param name="organisation">Organisation subdomain to login to (optional)</param>
        /// <param name="account">Account handle or id to login to (optional)</param>
        /// <returns>ApiResponse of UserLogin</returns>
        public ApiResponse< UserLogin > LoginWithHttpInfo (string email = null, string password = null, string organisation = null, string account = null)
        {

            var localVarPath = "/v1/authenticate/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (email != null) localVarFormParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (organisation != null) localVarFormParams.Add("organisation", Configuration.ApiClient.ParameterToString(organisation)); // form parameter
            if (account != null) localVarFormParams.Add("account", Configuration.ApiClient.ParameterToString(account)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Login", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserLogin>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLogin) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserLogin)));
            
        }

        /// <summary>
        /// User login 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">User email (optional)</param>
        /// <param name="password">User password (optional)</param>
        /// <param name="organisation">Organisation subdomain to login to (optional)</param>
        /// <param name="account">Account handle or id to login to (optional)</param>
        /// <returns>Task of UserLogin</returns>
        public async System.Threading.Tasks.Task<UserLogin> LoginAsync (string email = null, string password = null, string organisation = null, string account = null)
        {
             ApiResponse<UserLogin> localVarResponse = await LoginAsyncWithHttpInfo(email, password, organisation, account);
             return localVarResponse.Data;

        }

        /// <summary>
        /// User login 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">User email (optional)</param>
        /// <param name="password">User password (optional)</param>
        /// <param name="organisation">Organisation subdomain to login to (optional)</param>
        /// <param name="account">Account handle or id to login to (optional)</param>
        /// <returns>Task of ApiResponse (UserLogin)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserLogin>> LoginAsyncWithHttpInfo (string email = null, string password = null, string organisation = null, string account = null)
        {

            var localVarPath = "/v1/authenticate/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (email != null) localVarFormParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (organisation != null) localVarFormParams.Add("organisation", Configuration.ApiClient.ParameterToString(organisation)); // form parameter
            if (account != null) localVarFormParams.Add("account", Configuration.ApiClient.ParameterToString(account)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Login", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserLogin>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserLogin) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserLogin)));
            
        }

        /// <summary>
        /// Renew user login 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserRenew</returns>
        public UserRenew Renew ()
        {
             ApiResponse<UserRenew> localVarResponse = RenewWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Renew user login 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserRenew</returns>
        public ApiResponse< UserRenew > RenewWithHttpInfo ()
        {

            var localVarPath = "/v1/authenticate/renew";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Renew", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserRenew>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRenew) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRenew)));
            
        }

        /// <summary>
        /// Renew user login 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserRenew</returns>
        public async System.Threading.Tasks.Task<UserRenew> RenewAsync ()
        {
             ApiResponse<UserRenew> localVarResponse = await RenewAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Renew user login 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserRenew)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRenew>> RenewAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/authenticate/renew";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Renew", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserRenew>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRenew) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRenew)));
            
        }

        /// <summary>
        /// Verify authentication 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void VerifyAuthentication ()
        {
             VerifyAuthenticationWithHttpInfo();
        }

        /// <summary>
        /// Verify authentication 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> VerifyAuthenticationWithHttpInfo ()
        {

            var localVarPath = "/v1/authenticate/verify";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VerifyAuthentication", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Verify authentication 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task VerifyAuthenticationAsync ()
        {
             await VerifyAuthenticationAsyncWithHttpInfo();

        }

        /// <summary>
        /// Verify authentication 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VerifyAuthenticationAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/authenticate/verify";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VerifyAuthentication", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
