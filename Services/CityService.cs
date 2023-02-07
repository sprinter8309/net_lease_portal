using SearchNavigator.Data.Interfaces.Services;
using SearchNavigator.Data.Entities;
using SearchNavigator.Data;
using Microsoft.Extensions.Options;
using SearchNavigator.Data.Interfaces.Repositories;
using SearchNavigator.Repositories;
using SearchNavigator.Helpers;
using SearchNavigator.Constants;

namespace SearchNavigator.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository CityRepository)
        {
            this._cityRepository = CityRepository;
        }

        public IEnumerable<City> GetAllCities()
        {
            List<City> CitiesList = _cityRepository.GetAllCities().ToList();
            return CitiesList;
        }

        public IEnumerable<City> GetPartialSetOfCities()
        {
            List<City> CitiesList = _cityRepository.GetAllCities().ToList();
            return ListHelper.GetRandomPartOfElements(CitiesList, DisplayConst.MAIN_PAGE_CITIES_QUANT); 
        }

        public City? GetCityById(int Id)
        {
            return _cityRepository.GetCityById(Id);
        }
    }
}
