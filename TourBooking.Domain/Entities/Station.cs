using System;

namespace TourBooking.Domain.Entities
{
    public class Station
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? LatN { get; set; }
        public int? LongW { get; set; }
    }
}
