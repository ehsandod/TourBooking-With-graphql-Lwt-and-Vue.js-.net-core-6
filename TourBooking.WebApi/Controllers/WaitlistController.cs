using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using TourBooking.Application.DtoModels;
using TourBooking.Application.Services;
using TourBooking.WebApi.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WaitlistController : ControllerBase
    {
        private readonly IWaitlistService _waitlistService;
        private readonly ILogger<WaitlistController> _logger;
        private readonly IDistributedCache _distributedCache;

        public WaitlistController(IWaitlistService waitlistService, ILogger<WaitlistController> logger, IDistributedCache distributedCache)
        {
            _logger = logger;
            _distributedCache = distributedCache;
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


        //Redis Cash Sample
        public string LastTime { get; set; }
        [HttpGet("{testRedis}")]
        public void TestRedis()
        {
            var cachedTime = _distributedCache.Get("lastTime");
            if (cachedTime == null)
            {
                var timeNow=DateTime.Now.TimeOfDay;
                LastTime = timeNow.ToString();
                var bytes=Encoding.UTF8.GetBytes(timeNow.ToString());

                _distributedCache.Set("LastTime", bytes, new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10)
                });
                _logger.LogWarning("Time Cached to Redis");
            }
            else
            {
                LastTime=Encoding.UTF8.GetString(_distributedCache.Get("lasttime"));
            }
        }
    }
}

