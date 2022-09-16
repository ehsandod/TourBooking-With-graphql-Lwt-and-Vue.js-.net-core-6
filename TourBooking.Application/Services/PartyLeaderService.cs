using System.Linq;
using TourBooking.Domain.Contracts;
using TourBooking.Domain.Entities;

namespace TourBooking.Application.Services
{
    public class PartyLeaderService : IPartyLeaderService
    {
        private readonly IPartyLeaderRepository _partyLeaderRepository;
        public PartyLeaderService(IPartyLeaderRepository partyLeaderRepository)
        {
            _partyLeaderRepository = partyLeaderRepository;
        }

        public IQueryable<PartyLeader> GetPartyLeader()
        {
            return _partyLeaderRepository.GetAllAsQueryable();
        }
    }
}
