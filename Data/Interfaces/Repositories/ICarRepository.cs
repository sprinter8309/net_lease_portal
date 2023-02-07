using SearchNavigator.Data.Entities;

namespace SearchNavigator.Data.Interfaces.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllFreeCars();
        Car? GetCarById(int Id);
        IEnumerable<Car> GetCarsOfCity(int CityId);
    }
}
