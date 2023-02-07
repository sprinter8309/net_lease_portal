using Microsoft.AspNetCore.Mvc;
using SearchNavigator.Models;
using SearchNavigator.Data.Interfaces.Services;
using SearchNavigator.Data.Entities;
using SearchNavigator.Data;
using SearchNavigator.Constants;

namespace SearchNavigator.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ICarService _carService;

        public CityController(ICityService cityService, ICarService carService)
        {
            _cityService = cityService;
            _carService = carService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new CityIndexModel
            {
                cities = _cityService.GetAllCities(),
            });
        }

        [HttpGet]
        public IActionResult Single(int id)
        {
            City? CurrentCity = _cityService.GetCityById(id);

            if (CurrentCity != null)
            {
                return View(new CitySingleModel
                {
                    CityName = CurrentCity.Name,
                    CityCars = _carService.GetCarsOfCity(CurrentCity.Id)
                });
            }
            else {
                return NotFound(DisplayConst.CITY_NOT_FOUND_MESSAGE);
            }
        }
    }
}
