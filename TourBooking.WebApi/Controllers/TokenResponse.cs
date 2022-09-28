namespace TourBooking.WebApi.Controllers
{
    public class TokenResponse
    {
        public string? jwttoken { get; set; }
        public string? refreshtoken { get; set; }
    }
}
