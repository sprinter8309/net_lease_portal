using SearchNavigator.Data.Entities;

namespace SearchNavigator.Data.Interfaces.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetPartialSetOfCars();
        Car? GetCarById(int Id);
        IEnumerable<Car> GetAllFreeCars();
        IEnumerable<Car> GetCarsOfCity(int CityId);
    }
}
