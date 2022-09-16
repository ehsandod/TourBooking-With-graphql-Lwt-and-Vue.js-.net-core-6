using TourBooking.Application.Services;
using TourBooking.Domain.Entities;
using TourBooking.Domain.Entities.GraphQL;

namespace TourBooking.WebApi.GraphQL.Mutations
{
    public class BookingMutation
    {
        public async Task<AddBookingload> AddBookingAsync(AddBookingInput input, [Service] IBookingService bookingService)
        {
            var booking = new Booking
            {
                BookingId = input.Booking.BookingId,
                CreateDate = input.Booking.CreateDate,
                Currency = input.Booking.Currency,
                Name = input.Booking.Name,
                PartyLeader = new PartyLeader(),
                PartyLeaderId = input.Booking.PartyLeaderId,
                Price = input.Booking.Price,
                Status = input.Booking.Status
            };

            await bookingService.AddBooking(booking);
            return new AddBookingload(booking);
        }
    }
}
