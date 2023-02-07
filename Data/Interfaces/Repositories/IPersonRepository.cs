using SearchNavigator.Data.Entities;

namespace SearchNavigator.Data.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        int SavePersonRecord(Person NewPerson);
    }
}
