using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourBooking.Domain.Entities;

namespace TourBooking.Application.Services
{
    public interface IStationService
    {
        IQueryable<Station> GetAllStations();
        Station GetStation(int id);
        Task<int> GetIndistinctCount();
        IQueryable<Station> GetAllCitiesEndWithVowels();

    }
}
