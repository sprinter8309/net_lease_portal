using SearchNavigator.Data;
using SearchNavigator.Data.Entities;
using SearchNavigator.Data.Interfaces.Repositories;

namespace SearchNavigator.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private ApplicationDbContext _Context;

        public PersonRepository(SearchNavigator.Data.ApplicationDbContext Context)
        {
            _Context = Context;
        }

        public int SavePersonRecord(Person NewPerson)
        {
            _Context.Person.Add(NewPerson);
            return _Context.SaveChanges();
        }
    }
}
