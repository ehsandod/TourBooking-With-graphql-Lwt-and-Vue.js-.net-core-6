using System;
using System.Collections.Generic;

namespace TourBooking.Domain.Entities
{
    public class PartyLeader
    {
        public Guid PartyLeaderId { get; set; }
        public string Name { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
