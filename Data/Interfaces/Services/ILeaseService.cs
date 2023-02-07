using SearchNavigator.Data.Entities;
using SearchNavigator.Models;
using SearchNavigator.Models.DTO;

namespace SearchNavigator.Data.Interfaces.Services
{
    public interface ILeaseService
    {
        IEnumerable<LeaseShortInfoDTO> GetActualLeases();
        bool CreateNewLease(CarLeaseRequestModel carLeaseReqestModel);
    }
}
