using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TourBooking.Application.Commen.Entities;

namespace TourBooking.WebApi.Extensions
{
    public static class AuthenticationExtention
    {
        public static IServiceCollection AddOurAuthentication(this IServiceCollection services,
           AppSettings appSettings)
        {
            // Authorization service
            services.AddAuthorization(options =>
            {
                options.AddPolicy("GetAllUser",
                    policy => policy.RequireClaim("AccessAllUser", "True"));
            });

            // JWT Authentication
            var key = Encoding.ASCII.GetBytes(appSettings.Key);
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            return services;
        }
    }
}
