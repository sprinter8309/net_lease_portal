using SearchNavigator.Data.Entities;

namespace SearchNavigator.Models
{
    public class SiteIndexModel
    {
        public IEnumerable<City>? cities { get; set; }
        public IEnumerable<Car>? cars { get; set; }
    }
}
