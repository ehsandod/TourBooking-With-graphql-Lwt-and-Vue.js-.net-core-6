using TourBooking.Domain.Entities;

namespace TourBooking.WebApi.GraphQL.Types
{
    public class BookingType : ObjectType<Booking>
    {
        protected override void Configure(IObjectTypeDescriptor<Booking> descriptor)
        {
            descriptor.Description("Someone Has Booked Parties");
            descriptor.Field(a => a.BookingId).Description("Uniq Booking ID");

            descriptor.Field(a => a.CreateDate).Ignore();
            //descriptor.Field(a => a.PartyLeader).IsProjected(true);
        }

    }
}
