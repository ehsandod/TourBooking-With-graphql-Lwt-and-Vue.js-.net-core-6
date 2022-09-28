using Microsoft.AspNetCore.Authorization;
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
        [HttpPost("login")]
        public User Login([FromBody] UserDto user)
        {
            var thisUser= _userService.Authenticate(user.UserName, user.Password);
            return thisUser; 
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public IEnumerable<User> GetAllUser()
        {
            return _userService.GetAll();
        }

        //private IConfiguration _config;

        //public LoginController(IConfiguration config)
        //{
        //    _config = config;
        //}

        //[AllowAnonymous]
        //[HttpPost]
        //public IActionResult Login([FromBody] UserDto user)
        //{
        //    IActionResult response = Unauthorized();
        //    var user = AuthenticateUser(user);

        //    if (user != null)
        //    {
        //        var tokenString = GenerateJSONWebToken(user);
        //        response = Ok(new { token = tokenString });
        //    }

        //    return response;
        //}

        //[HttpGet("ghofl")]
        //[Authorize]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    var currentUser = HttpContext.User;
        //    int spendingTimeWithCompany = 0;

        //    if (currentUser.HasClaim(c => c.Type == "DateOfJoing"))
        //    {
        //        DateTime date = DateTime.Parse(currentUser.Claims.FirstOrDefault(c => c.Type == "DateOfJoing").Value);
        //        spendingTimeWithCompany = DateTime.Today.Year - date.Year;
        //    }

        //    if (spendingTimeWithCompany > 5)
        //    {
        //        return new string[] { "High Time1", "High Time2", "High Time3", "High Time4", "High Time5" };
        //    }
        //    else
        //    {
        //        return new string[] { "value1", "value2", "value3", "value4", "value5" };
        //    }
        //}



        //private string GenerateJSONWebToken(UserModel userInfo)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //    var token = new JwtSecurityToken(_config["Jwt:Issuer"],
        //      _config["Jwt:Issuer"],
        //      null,
        //      expires: DateTime.Now.AddMinutes(120),
        //      signingCredentials: credentials);

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}

        //private UserModel AuthenticateUser(UserModel login)
        //{
        //    UserModel user = null;

        //    //Validate the User Credentials    
        //    //Demo Purpose, I have Passed HardCoded User Information    
        //    if (login.Username == "Jignesh")
        //    {
        //        user = new UserModel { Username = "Jignesh Trivedi", EmailAddress = "test.btest@gmail.com" };
        //    }
        //    return user;
        //}

    }
}
