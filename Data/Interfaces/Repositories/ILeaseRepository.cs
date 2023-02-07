using SearchNavigator.Data.Entities;
using SearchNavigator.Models.DTO;

namespace SearchNavigator.Data.Interfaces.Repositories
{
    public interface ILeaseRepository
    {
        IEnumerable<LeaseShortInfoDTO> GetActualLeases();
        int SaveLeaseRecord(Lease NewLease);
    }
}
