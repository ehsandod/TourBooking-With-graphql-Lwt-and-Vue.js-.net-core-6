using TourBooking.Application.Services;
using TourBooking.Domain.Entities;

namespace TourBooking.WebApi.GraphQL.Queries
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Booking> GetBookings([Service] IBookingService bookingService)
            => bookingService.GetBookings();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<PartyLeader> GetPartyLeader([Service] IPartyLeaderService partyLeaderService)
            => partyLeaderService.GetPartyLeader();
    }
}