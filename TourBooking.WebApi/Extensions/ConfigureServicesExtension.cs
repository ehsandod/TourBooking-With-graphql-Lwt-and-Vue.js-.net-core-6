using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TourBooking.Application.Services;
using TourBooking.Domain.Contracts;
using TourBooking.Infrastructure.DBContext;
using TourBooking.Infrastructure.Repositories;
using TourBooking.WebApi.GraphQL.Mutations;
using TourBooking.WebApi.GraphQL.Queries;
using TourBooking.WebApi.GraphQL.Types;

namespace TourBooking.WebApi.Extensions
{
    public static class ConfigureServicesExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddDbContextFactory<ApplicationDBContext>(options =>
                options.UseSqlServer("name=ConnectionStrings:DefaultConnection"),
                ServiceLifetime.Scoped);

            //Swagger
            //tamome ? chiye digei  hast?
            //in dota sql query ro bebin
            services.AddSwaggerGen(setup =>
            {
                // Include 'SecurityScheme' to use JWT Authentication
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

                setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { jwtSecurityScheme, Array.Empty<string>() }
                });

            });

            services.AddMvc();

            //IOC
            services.AddScoped(typeof(IBookingRepository), typeof(BookingRepository));
            services.AddScoped(typeof(IBookingService), typeof(BookingService));

            services.AddScoped(typeof(IPartyLeaderRepository), typeof(PartyLeaderRepository));
            services.AddScoped(typeof(IPartyLeaderService), typeof(PartyLeaderService));

            services.AddScoped(typeof(IStationRepository), typeof(StationRepository));
            services.AddScoped(typeof(IStationService), typeof(StationService));

            services.AddScoped(typeof(IWaitlistRepository), typeof(WaitlistRepository));
            services.AddScoped(typeof(IWaitlistService), typeof(WaitlistService));

            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IUserService), typeof(UserService));



            //GraphQl Configurations.
            services
                .AddGraphQLServer()
                .AddProjections()
                .AddType<BookingType>()
                .AddMutationType<BookingMutation>()
                .AddFiltering()
                .AddSorting()
                .AddQueryType<Query>();
        }
    }
}
