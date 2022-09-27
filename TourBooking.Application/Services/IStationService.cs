using System.Collections.Generic;
using System.Linq;
using TourBooking.Domain.Entities;

namespace TourBooking.Application.Services
{
    public interface IStationService
    {
        IQueryable<Station> GetAllStations();
        Station GetStation(int id);
        int GetIndistinctCount();
        IQueryable<Station> GetAllCitiesEndWithVowels();

    }
}
