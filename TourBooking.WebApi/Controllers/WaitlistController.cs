using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaitlistController : ControllerBase
    {
        // GET: api/<WaitlistController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WaitlistController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WaitlistController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WaitlistController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WaitlistController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
