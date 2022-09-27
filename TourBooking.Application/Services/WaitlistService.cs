using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourBooking.Domain.Contracts;
using TourBooking.Domain.Entities;
using TourBooking.Infrastructure.DBContext;

namespace TourBooking.Application.Services
{
    public class WaitlistService : IWaitlistService
    {
        private readonly IWaitlistRepository _waitlistRepository;

        public WaitlistService(IWaitlistRepository waitlistRepository)
        {
            _waitlistRepository = waitlistRepository;
        }

        public IQueryable<Waitlist> GetAllWaitList()
        {
           return _waitlistRepository.GetAllAsQueryable();
        }

        public Waitlist GetWaitlist(int id)
        {
          return _waitlistRepository.GetById(id);
        }
        public IQueryable<Waitlist> GetAllWaitlistWithNewStructure()
        {
            //var author = _waitlistRepository.getallfromsql();
            return _waitlistRepository.GetAllAsQueryable();
        }
    }
}
