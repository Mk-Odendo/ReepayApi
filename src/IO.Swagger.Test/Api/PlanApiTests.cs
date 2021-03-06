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
    ///  Class for testing PlanApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PlanApiTests
    {
        private PlanApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PlanApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PlanApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PlanApi
            //Assert.IsInstanceOfType(typeof(PlanApi), instance, "instance is a PlanApi");
        }

        
        /// <summary>
        /// Test CreatePlanJson
        /// </summary>
        [Test]
        public void CreatePlanJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateSubscriptionPlan body = null;
            //var response = instance.CreatePlanJson(body);
            //Assert.IsInstanceOf<Plan> (response, "response is Plan");
        }
        
        /// <summary>
        /// Test DeletePlan
        /// </summary>
        [Test]
        public void DeletePlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //var response = instance.DeletePlan(handle);
            //Assert.IsInstanceOf<Plan> (response, "response is Plan");
        }
        
        /// <summary>
        /// Test GetCurrentPlan
        /// </summary>
        [Test]
        public void GetCurrentPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //var response = instance.GetCurrentPlan(handle);
            //Assert.IsInstanceOf<Plan> (response, "response is Plan");
        }
        
        /// <summary>
        /// Test GetPlan
        /// </summary>
        [Test]
        public void GetPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //int? version = null;
            //var response = instance.GetPlan(handle, version);
            //Assert.IsInstanceOf<Plan> (response, "response is Plan");
        }
        
        /// <summary>
        /// Test GetPlans
        /// </summary>
        [Test]
        public void GetPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //var response = instance.GetPlans(handle);
            //Assert.IsInstanceOf<List<Plan>> (response, "response is List<Plan>");
        }
        
        /// <summary>
        /// Test GetPlansList
        /// </summary>
        [Test]
        public void GetPlansListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? onlyActive = null;
            //var response = instance.GetPlansList(onlyActive);
            //Assert.IsInstanceOf<List<Plan>> (response, "response is List<Plan>");
        }
        
        /// <summary>
        /// Test SupersedePlanJson
        /// </summary>
        [Test]
        public void SupersedePlanJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //SupersedeSubscriptionPlan body = null;
            //var response = instance.SupersedePlanJson(handle, body);
            //Assert.IsInstanceOf<Plan> (response, "response is Plan");
        }
        
        /// <summary>
        /// Test UpdatePlanJson
        /// </summary>
        [Test]
        public void UpdatePlanJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //UpdateSubscriptionPlan body = null;
            //var response = instance.UpdatePlanJson(handle, body);
            //Assert.IsInstanceOf<Plan> (response, "response is Plan");
        }
        
    }

}
