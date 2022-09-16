using System;

namespace TourBooking.Domain.Entities
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public Int16 Status { get; set; }
        public int Price { get; set; }
        public Nullable<Int16> Currency { get; set; }
        public Guid PartyLeaderId { get; set; }
        public PartyLeader PartyLeader { get; set; }
    }
}
