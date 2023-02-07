using Microsoft.AspNetCore.Mvc;
using SearchNavigator.Data.Interfaces.Services;
using SearchNavigator.Data.Entities;
using SearchNavigator.Models;
using System.Diagnostics;

namespace SearchNavigator.Controllers
{
    public class SiteController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ICarService _carService;

        public SiteController(ICityService cityService, ICarService carService)
        {
            _cityService = cityService;
            _carService = carService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new SiteIndexModel
            {
                cities = _cityService.GetPartialSetOfCities(),
                cars = _carService.GetPartialSetOfCars()
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
