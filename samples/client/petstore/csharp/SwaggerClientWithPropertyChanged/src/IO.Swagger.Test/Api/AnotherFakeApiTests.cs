/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    ///  Class for testing AnotherFakeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AnotherFakeApiTests
    {
        private AnotherFakeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AnotherFakeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnotherFakeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AnotherFakeApi
            //Assert.IsInstanceOfType(typeof(AnotherFakeApi), instance, "instance is a AnotherFakeApi");
        }

        /// <summary>
        /// Test TestSpecialTags
        /// </summary>
        [Test]
        public void TestSpecialTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ModelClient body = null;
            //var response = instance.TestSpecialTags(body);
            //Assert.IsInstanceOf<ModelClient> (response, "response is ModelClient");
        }
    }

}
