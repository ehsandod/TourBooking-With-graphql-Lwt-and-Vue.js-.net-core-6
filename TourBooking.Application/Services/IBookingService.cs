using System.Linq;
using System.Threading.Tasks;
using TourBooking.Domain.Entities;

namespace TourBooking.Application.Services
{
    public interface IBookingService
    {
        IQueryable<Booking> GetBookings();
        Task AddBooking(Booking booking);
    }
}
