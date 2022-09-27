using TourBooking.Domain.Contracts;
using TourBooking.Domain.Entities;
using TourBooking.Infrastructure.DBContext;
using TourBooking.Infrastructure.GenericRepository;

namespace TourBooking.Infrastructure.Repositories
{
    public class StationRepository : GenericRepository<Station>, IStationRepository
    {
        public StationRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
