using TourBooking.Domain.Contracts;
using TourBooking.Domain.Entities;
using TourBooking.Infrastructure.DBContext;
using TourBooking.Infrastructure.GenericRepository;

namespace TourBooking.Infrastructure.Repositories
{
    public class WaitlistRepository : GenericRepository<Waitlist>, IWaitlistRepository
    {
        public WaitlistRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        //public IQueryable<Waitlist> getallfromsql()
        //{

        //    var waitlist = _dbContext.Waitlists.FromSqlRaw("SELECT listname, [Name]=cast(id as varchar)+','+firstname+' '+lastname, ROW_NUMBER() OVER (PARTITION BY listName ORDER BY created ) AS RowNum\r\nFROM Waitlists");
        //    return waitlist;
        //}
    } 
}

