using Microsoft.AspNetCore.Mvc;
using SearchNavigator.Models;
using SearchNavigator.Data.Interfaces.Services;
using SearchNavigator.Data.Entities;
using SearchNavigator.Constants;
using System.Net;

namespace SearchNavigator.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ILeaseService _leaseService;

        public CarController(ICarService carService, ILeaseService leaseService)
        {
            _carService = carService;
            _leaseService = leaseService;
        }

        [HttpGet]
        public IActionResult Index()
        {         
            return View(new CarIndexModel
            {
                cars = _carService.GetAllFreeCars()
            });
        }

        [HttpGet]
        public IActionResult Single(int id)
        {
            Car? FoundCar = _carService.GetCarById(id);

            if (FoundCar != null)
            {
                return View(new CarSingleModel {
                    CarItem = _carService.GetCarById(id)
                });
            } else {
                return NotFound(DisplayConst.CAR_NOT_FOUND_MESSAGE);
            }           
        }

        [HttpGet]
        public IActionResult LeaseRequest(int id)
        {
            var CarInfo = _carService.GetCarById(id);

            return View(new CarLeaseRequestModel
            {
                CarId = CarInfo.Id,
                CarPreviewImage = CarInfo.PreviewImage,
                CarBrand = (CarInfo.Brand.Name),
                CarModel = CarInfo.Model,
                CarCity = CarInfo.City.Name,
                CarLeaseRate = CarInfo.LeaseRate
            });
        }

        [HttpPost]
        public IActionResult LeaseRequest(CarLeaseRequestModel RequestModel)
        {
            if (!ModelState.IsValid) {
                var CarInfo = _carService.GetCarById(RequestModel.CarId);

                RequestModel.CarPreviewImage = CarInfo.PreviewImage;
                RequestModel.CarBrand = CarInfo.Brand.Name;
                RequestModel.CarModel = CarInfo.Model;
                RequestModel.CarCity = CarInfo.City.Name;
                RequestModel.CarLeaseRate = CarInfo.LeaseRate;

                return View(RequestModel);
            }

            _leaseService.CreateNewLease(RequestModel);

            return RedirectToAction("Index", "Admin");
        }
    }
}
