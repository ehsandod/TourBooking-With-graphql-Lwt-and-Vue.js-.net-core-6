using System.Linq;
using TourBooking.Domain.Entities;

namespace TourBooking.Application.Services
{
    public interface IPartyLeaderService
    {
        IQueryable<PartyLeader> GetPartyLeader();
    }
}
