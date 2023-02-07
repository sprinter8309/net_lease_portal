using SearchNavigator.Data;
using SearchNavigator.Data.Entities;
using SearchNavigator.Data.Interfaces.Repositories;

namespace SearchNavigator.Repositories
{
    public class CityRepository : ICityRepository
    {
        private ApplicationDbContext _Context;

        public CityRepository(ApplicationDbContext Context)
        {
            _Context = Context;
        }

        public IEnumerable<City> GetAllCities()
        {
            return _Context.City.Where(c => c.IsDelete != true);
        }

        public City? GetCityById(int Id)
        {
            return _Context.City.Where(c => c.IsDelete != true && 
                                       c.Id == Id).
                                 SingleOrDefault();
        }
    }
}
