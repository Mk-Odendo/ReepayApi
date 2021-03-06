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

namespace ReepayApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMailTemplateApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get sample data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> GetSample ();

        /// <summary>
        /// Get sample data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> GetSampleWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get sample data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, Object>> GetSampleAsync ();

        /// <summary>
        /// Get sample data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetSampleAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MailTemplateApi : IMailTemplateApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailTemplateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MailTemplateApi(String basePath)
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
        /// Initializes a new instance of the <see cref="MailTemplateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MailTemplateApi(Configuration configuration = null)
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
        /// Get sample data 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> GetSample ()
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = GetSampleWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get sample data 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse< Dictionary<string, Object> > GetSampleWithHttpInfo ()
        {

            var localVarPath = "/v1/mail_template/sample";
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
                Exception exception = ExceptionFactory("GetSample", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)));
            
        }

        /// <summary>
        /// Get sample data 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, Object>> GetSampleAsync ()
        {
             ApiResponse<Dictionary<string, Object>> localVarResponse = await GetSampleAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get sample data 
        /// </summary>
        /// <exception cref="ReepayApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> GetSampleAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/mail_template/sample";
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
                Exception exception = ExceptionFactory("GetSample", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)));
            
        }

    }
}
