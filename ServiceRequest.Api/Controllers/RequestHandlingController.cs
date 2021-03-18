using Microsoft.AspNetCore.Mvc;
using ServiceRequest.Logic.Contracts;
using ServiceRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceRequest.Api.Controllers
{
    [Route("api/servicerequest")]
    [ApiController]
    public class RequestHandlingController : ControllerBase
    {
        IServiceRequestLogic _logic;
        public RequestHandlingController(IServiceRequestLogic logic)
        {
            _logic = logic;
        }

        // GET: api/<RequestHandlingController>
        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(_logic.GetData());
        }

        // GET api/<RequestHandlingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RequestHandlingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RequestHandlingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RequestHandlingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
