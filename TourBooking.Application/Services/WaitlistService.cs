using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourBooking.Application.DtoModels;
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
        public async Task<List<WaitlistAdminStructDto>> GetAllWaitlistAdminStructure()
        {
            var index = 0;
            var query=await _waitlistRepository.GetAllAsQueryable().OrderBy(x=>x.Created).ToListAsync();
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Waitlist, WaitlistAdminStructDto>()
            .ForMember(dest=>dest.FullName,opt=>opt.MapFrom(src=>src.Firstname+" "+src.Lastname))
            .ForMember(dest=>dest.RowNumber, opt => index++));
            var mapper = config.CreateMapper();
            var result = mapper.Map<List<WaitlistAdminStructDto>>(query);
           
            return result;
        }
    }
}
