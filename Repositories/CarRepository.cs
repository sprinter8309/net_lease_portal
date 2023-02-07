using Microsoft.EntityFrameworkCore;
using SearchNavigator.Data;
using SearchNavigator.Data.Entities;
using SearchNavigator.Data.Interfaces.Repositories;

namespace SearchNavigator.Repositories
{
    public class CarRepository : ICarRepository
    {
        private ApplicationDbContext _Context;

        public CarRepository(ApplicationDbContext Context)
        {
            _Context = Context;
        }

        public IEnumerable<Car> GetAllFreeCars()
        {
            return _Context.Car.Include(c => c.Brand).
                                Include(c => c.City).
                                Where(c => !GetLeaseCarsIds().Contains(c.Id) && 
                                      c.IsDelete!=true);
        }

        public Car? GetCarById(int Id)
        {
            return _Context.Car.Include(c => c.Brand).
                                Include(c => c.City).
                                Where(c => !GetLeaseCarsIds().Contains(c.Id) && 
                                      c.IsDelete != true && 
                                      c.Id==Id).
                                SingleOrDefault();
        }
       
        public IEnumerable<Car> GetCarsOfCity(int CityId)
        {
            return _Context.Car.Include(c => c.Brand).
                                Include(c => c.City).
                                Where(c => !GetLeaseCarsIds().Contains(c.Id) && 
                                      c.IsDelete != true && 
                                      c.City.Id == CityId);
        }

        public int[] GetLeaseCarsIds()
        { 
            return _Context.Lease.Where(l => l.DeletedAt == null).Select(l => l.CarId).ToArray();
        }
    }
}
