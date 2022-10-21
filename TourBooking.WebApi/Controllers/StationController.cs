using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TourBooking.Application.Services;
using TourBooking.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class StationController : ControllerBase
    {
        private readonly IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }

        // GET: api/<Station2Controller>
        [HttpGet("GetIndistinctCount")]
        public async Task<IActionResult> GetIndistinctCount()
        {
            var diffrence=await _stationService.GetIndistinctCount();
            return Ok(diffrence);
        }
        
        // GET: api/<Station2Controller>
        [HttpGet("GetAllCitiesEndWithVowels")]
        public List<Station> GetAllCitiesEndWithVowels()
        {
            return _stationService.GetAllCitiesEndWithVowels().ToList();
        }

        // GET api/<Station2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Station2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Station2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Station2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
