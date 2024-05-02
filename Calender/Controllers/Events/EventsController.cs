using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using Calendar.Events.Interface.Iservice;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calendar.Controllers.Events
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IEventService _eventService;
        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
           var data =await _eventService.Getall();
            var response = new object();
            if (data == null)
            {
                response = new
                {
                    success = false,
                    statusCode = HttpStatusCode.BadRequest,
                    data = DBNull.Value,
                };
                return Ok(response);
            }
            else
            {
                response = new
                {
                    success = true,
                    statusCode = HttpStatusCode.OK,
                    data = data,
                };
                return Ok(response);
            }
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
