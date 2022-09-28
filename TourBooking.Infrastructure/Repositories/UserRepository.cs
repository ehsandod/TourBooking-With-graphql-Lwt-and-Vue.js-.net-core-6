using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourBooking.Domain.Contracts;
using TourBooking.Domain.Entities;
using TourBooking.Infrastructure.DBContext;
using TourBooking.Infrastructure.GenericRepository;

namespace TourBooking.Infrastructure.Repositories
{

    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
