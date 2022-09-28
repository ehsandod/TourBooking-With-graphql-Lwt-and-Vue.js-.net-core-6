using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourBooking.Application.DtoModels;
using TourBooking.Domain.Entities;

namespace TourBooking.Application.Services
{
    public interface IWaitlistService
    {
        IQueryable<Waitlist> GetAllWaitList();
        Waitlist GetWaitlist(int id);
        Task<List<WaitlistAdminStructDto>> GetAllWaitlistAdminStructure();

    }
}
