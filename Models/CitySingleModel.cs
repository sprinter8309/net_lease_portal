using SearchNavigator.Data.Entities;

namespace SearchNavigator.Models
{
    public class CitySingleModel
    {
        public string? CityName { get; set; }
        public IEnumerable<Car>? CityCars { get; set; }
    }
}
