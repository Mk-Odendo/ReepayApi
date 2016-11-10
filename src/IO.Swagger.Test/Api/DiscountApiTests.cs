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
    ///  Class for testing DiscountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DiscountApiTests
    {
        private DiscountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DiscountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DiscountApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DiscountApi
            //Assert.IsInstanceOfType(typeof(DiscountApi), instance, "instance is a DiscountApi");
        }

        
        /// <summary>
        /// Test CreateDiscount
        /// </summary>
        [Test]
        public void CreateDiscountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateDiscount body = null;
            //var response = instance.CreateDiscount(body);
            //Assert.IsInstanceOf<Discount> (response, "response is Discount");
        }
        
        /// <summary>
        /// Test DeleteDiscount
        /// </summary>
        [Test]
        public void DeleteDiscountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //var response = instance.DeleteDiscount(handle);
            //Assert.IsInstanceOf<Discount> (response, "response is Discount");
        }
        
        /// <summary>
        /// Test GetDiscount
        /// </summary>
        [Test]
        public void GetDiscountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //var response = instance.GetDiscount(handle);
            //Assert.IsInstanceOf<Discount> (response, "response is Discount");
        }
        
        /// <summary>
        /// Test GetDiscounts
        /// </summary>
        [Test]
        public void GetDiscountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string search = null;
            //string sort = null;
            //var response = instance.GetDiscounts(page, size, search, sort);
            //Assert.IsInstanceOf<DiscountSearch> (response, "response is DiscountSearch");
        }
        
        /// <summary>
        /// Test UndeleteDiscount
        /// </summary>
        [Test]
        public void UndeleteDiscountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //var response = instance.UndeleteDiscount(handle);
            //Assert.IsInstanceOf<Discount> (response, "response is Discount");
        }
        
    }

}