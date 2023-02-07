using SearchNavigator.Data;
using SearchNavigator.Data.Entities;
using SearchNavigator.Data.Interfaces.Repositories;
using SearchNavigator.Models.DTO;

namespace SearchNavigator.Repositories
{
    public class LeaseRepository : ILeaseRepository
    {
        private ApplicationDbContext _Context;

        public LeaseRepository(ApplicationDbContext Context)
        {
            this._Context = Context;
        }

        public IEnumerable<LeaseShortInfoDTO> GetActualLeases()
        {
            return from lease in _Context.Lease
                         join car in _Context.Car on lease.CarId equals car.Id
                         join person in _Context.Person on lease.PersonId equals person.Id
                         where lease.DeletedAt == null 
                         select new LeaseShortInfoDTO
                         {
                             CarBrand = car.Brand.Name,
                             CarModel = car.Model,
                             CarColor = car.Color,
                             CarIssueYear = car.IssueYear,
                             CarNumber = car.Number,
                             CarLeaseRate = car.LeaseRate,
                             CarCity = car.City.Name, 
                             PersonName = person.Name,
                             PersonPhone = person.Phone
                         };
        }

        public int SaveLeaseRecord(Lease NewLease)
        {
            _Context.Lease.Add(NewLease);
            return _Context.SaveChanges();
        }
    }
}
