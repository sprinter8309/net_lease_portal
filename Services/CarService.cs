using SearchNavigator.Data.Interfaces.Services;
using SearchNavigator.Data.Interfaces.Repositories;
using SearchNavigator.Data.Entities;
using SearchNavigator.Repositories;
using SearchNavigator.Constants;
using SearchNavigator.Helpers;

namespace SearchNavigator.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository CarRepository)
        {
            this._carRepository = CarRepository;
        }

        public IEnumerable<Car> GetPartialSetOfCars()
        {
            List<Car> CarsList = _carRepository.GetAllFreeCars().ToList();
            return ListHelper.GetRandomPartOfElements(CarsList, DisplayConst.MAIN_PAGE_CARS_QUANT);
        }

        public Car? GetCarById(int Id)
        {
            return _carRepository.GetCarById(Id);
        }

        public IEnumerable<Car> GetAllFreeCars()
        {
            return _carRepository.GetAllFreeCars();
        }
        
        public IEnumerable<Car> GetCarsOfCity(int CityId)
        {
            return _carRepository.GetCarsOfCity(CityId);
        }
    }
}
