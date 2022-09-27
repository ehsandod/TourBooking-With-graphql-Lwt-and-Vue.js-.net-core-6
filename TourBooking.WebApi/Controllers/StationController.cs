using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourBooking.Application.Services;
using TourBooking.Domain.Entities;

namespace TourBooking.WebApi.Controllers
{
    public class StationController : Controller
    {
        private readonly IStationService _stationService;
        private readonly WaitlistService _waitlistService;


        public StationController(WaitlistService waitlistService1, IStationService stationService, IWaitlistService waitlistService)
        {

            _stationService = stationService;
            _waitlistService = waitlistService1;
        }

        // GET: StationController
        public ActionResult IndGetIndistinctCountex()
        {
            //var s= _stationService.GetAllStations().Select(x=>x.City).Distinct().Count();
            var count = _stationService.GetIndistinctCount();
            return View();
        }

        public ActionResult GetAllCitiesEndWithVowels()
        {
            _waitlistService.GetAllWaitlistWithNewStructure();
            //var s= _stationService.GetAllStations().Select(x=>x.City).Distinct().Count();
            var count = _stationService.GetAllCitiesEndWithVowels().ToList();
            return View();
        }

        // GET: StationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
