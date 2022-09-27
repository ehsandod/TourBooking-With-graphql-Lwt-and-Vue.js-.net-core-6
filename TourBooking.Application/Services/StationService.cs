using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TourBooking.Application.Commen;
using TourBooking.Domain.Contracts;
using TourBooking.Domain.Entities;

namespace TourBooking.Application.Services
{
    public class StationService : IStationService
    {
        private readonly IStationRepository _stationRepository;

        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }

        public Station GetStation(int id)
        {
           
            return _stationRepository.GetById(id);
        }

        public IQueryable<Station> GetAllStations()
        {
            return _stationRepository.GetAllAsQueryable();
        }

        public int GetIndistinctCount()
        {
            return
            _stationRepository.Count() - _stationRepository.GetAllAsQueryable().GroupBy(x => x.City).Count();
        }

        public IQueryable<Station> GetAllCitiesEndWithVowels()
        {
            var ewe = _stationRepository.GetAllAsQueryable().Where(x => !x.City.EndsWith("e") &
                                                                        !x.City.EndsWith("a") &
                                                                        !x.City.EndsWith("i") &
                                                                        !x.City.EndsWith("o") &
                                                                        !x.City.EndsWith("u"));
            return ewe;
        }
    }
}
