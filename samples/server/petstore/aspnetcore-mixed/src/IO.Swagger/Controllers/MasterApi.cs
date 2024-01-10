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
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class MasterApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">peticion realizada con exito</response>
        [HttpGet]
        [Route("/v3/master")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("MasterOperation")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<PartMaster>), description: "peticion realizada con exito")]
        public virtual IActionResult MasterOperation()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<PartMaster>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"origin\" : \"\",\n  \"destination\" : \"\"\n}, {\n  \"origin\" : \"\",\n  \"destination\" : \"\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<PartMaster>>(exampleJson)
                        : default(List<PartMaster>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
