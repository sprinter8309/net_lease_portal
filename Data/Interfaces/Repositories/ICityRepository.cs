using SearchNavigator.Data.Entities;

namespace SearchNavigator.Data.Interfaces.Repositories
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAllCities();
        City? GetCityById(int Id);
    }
}
