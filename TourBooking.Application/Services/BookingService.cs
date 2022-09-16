using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TourBooking.Domain.Contracts;
using TourBooking.Domain.Entities;

namespace TourBooking.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task AddBooking(Booking booking)
        {
            _bookingRepository.Insert(booking);
            await _bookingRepository.SaveChangesAsync();
        }

        IQueryable<Booking> IBookingService.GetBookings()
        {
            return _bookingRepository.GetAllAsQueryable().Include(x => x.PartyLeader);
        }
    }
}
