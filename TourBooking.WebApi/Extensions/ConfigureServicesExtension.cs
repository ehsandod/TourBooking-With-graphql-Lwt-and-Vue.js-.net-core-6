using Microsoft.EntityFrameworkCore;
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

            //IOC
            services.AddScoped(typeof(IBookingRepository), typeof(BookingRepository));
            services.AddScoped(typeof(IPartyLeaderRepository), typeof(PartyLeaderRepository));

            services.AddScoped(typeof(IBookingService), typeof(BookingService));
            services.AddScoped(typeof(IPartyLeaderService), typeof(PartyLeaderService));

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
