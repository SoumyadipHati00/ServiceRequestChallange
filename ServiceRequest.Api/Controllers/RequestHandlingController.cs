using Microsoft.AspNetCore.Mvc;
using ServiceRequest.Logic.Contracts;
using ServiceRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public IActionResult Get()
        {
            var data = _logic.GetData();
            if (data != null && data.Count > 0)
            {
                return Ok(data);
            }
            else
            {
                return new EmptyResult();
            }
        }

        // GET api/<RequestHandlingController>/bf185331-3829-4e92-b03d-cdb6e78a156f
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var data = _logic.GetData(id);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/<RequestHandlingController>
        [HttpPost]
        public IActionResult Post([FromBody] List<ServiceRequestDetails> requestList)
        {

            if (_logic.InsertData(requestList))
            {
                return Created(new Uri($"{Request.Host}/api/servicerequest"), true);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<RequestHandlingController>/bf185331-3829-4e92-b03d-cdb6e78a156f
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] ServiceRequestDetails request)
        {
            var data = _logic.GetData(id);
            if (data != null)
            {
                if (_logic.UpdateData(request))
                {
                    return Ok(true);
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<RequestHandlingController>/bf185331-3829-4e92-b03d-cdb6e78a156f
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var data = _logic.GetData(id);
            if (data != null)
            {
                if (_logic.DeleteData(id))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
