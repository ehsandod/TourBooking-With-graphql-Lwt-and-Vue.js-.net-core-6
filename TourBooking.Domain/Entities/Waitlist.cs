using System;

namespace TourBooking.Domain.Entities
{
    public class Waitlist
    {
        public int Id { get; set; }
        public string Listname { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Created { get; set; }
    }
}
