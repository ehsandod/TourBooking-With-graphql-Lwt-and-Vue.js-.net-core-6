using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using TourBooking.Application.DtoModels;
using TourBooking.Application.Services;
using TourBooking.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<IActionResult> Login(string user, string password)
        {
            var User= await _userService.AuthenticateAsync(user, password);
            return Ok(User);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("getalluser")]
        public async Task<IActionResult> GetAllUser()
        {
            var allUsers = await _userService.GetAllAsync();
            return Ok(allUsers);
        }
    }
}
