using Microsoft.AspNetCore.Mvc;
using TourBooking.Application.DtoModels;
using TourBooking.Application.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaitlistController : ControllerBase
    {
        private readonly IWaitlistService _waitlistService;

        public WaitlistController(IWaitlistService waitlistService)
        {
            _waitlistService = waitlistService;
        }

        // GET: api/<WaitlistController>
        [HttpGet("GetAllWaitlistAdminStructure")]
        public async Task<IActionResult> GetAllWaitlistAdminStructure()
        {
            var test = await _waitlistService.GetAllWaitlistAdminStructure();
            return Ok(test.ToList());
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
