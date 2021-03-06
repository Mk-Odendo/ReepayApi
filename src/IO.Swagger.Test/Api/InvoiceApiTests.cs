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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing InvoiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvoiceApiTests
    {
        private InvoiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvoiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvoiceApi
            //Assert.IsInstanceOfType(typeof(InvoiceApi), instance, "instance is a InvoiceApi");
        }

        
        /// <summary>
        /// Test CancelAllDunningPending
        /// </summary>
        [Test]
        public void CancelAllDunningPendingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //var response = instance.CancelAllDunningPending(handle);
            //Assert.IsInstanceOf<List<Invoice>> (response, "response is List<Invoice>");
        }
        
        /// <summary>
        /// Test CancelInvoice
        /// </summary>
        [Test]
        public void CancelInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.CancelInvoice(id);
            //Assert.IsInstanceOf<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test GetInvoice
        /// </summary>
        [Test]
        public void GetInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetInvoice(id);
            //Assert.IsInstanceOf<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test GetInvoices
        /// </summary>
        [Test]
        public void GetInvoicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string search = null;
            //string sort = null;
            //var response = instance.GetInvoices(page, size, search, sort);
            //Assert.IsInstanceOf<InvoiceSearch> (response, "response is InvoiceSearch");
        }
        
        /// <summary>
        /// Test ManualSettle
        /// </summary>
        [Test]
        public void ManualSettleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ManualSettleTransfer body = null;
            //var response = instance.ManualSettle(id, body);
            //Assert.IsInstanceOf<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test ReactivateInvoice
        /// </summary>
        [Test]
        public void ReactivateInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ReactivateInvoice(id);
            //Assert.IsInstanceOf<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test Refund
        /// </summary>
        [Test]
        public void RefundTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //RefundInvoice body = null;
            //var response = instance.Refund(id, body);
            //Assert.IsInstanceOf<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test TransactionDetails
        /// </summary>
        [Test]
        public void TransactionDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string transaction = null;
            //var response = instance.TransactionDetails(id, transaction);
            //Assert.IsInstanceOf<Dictionary<string, Object>> (response, "response is Dictionary<string, Object>");
        }
        
    }

}
