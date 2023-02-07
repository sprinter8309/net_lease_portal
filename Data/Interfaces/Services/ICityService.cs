using SearchNavigator.Data.Entities;

namespace SearchNavigator.Data.Interfaces.Services
{
    public interface ICityService
    {
        IEnumerable<City> GetAllCities();
        City? GetCityById(int Id);
        IEnumerable<City> GetPartialSetOfCities();
    }
}
