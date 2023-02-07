using SearchNavigator.Data.Entities;
using SearchNavigator.Models;

namespace SearchNavigator.Data.Interfaces.Factories
{
    public interface ILeaseFactory
    {
        Lease CreateLease(CarLeaseRequestModel carLeaseReqestModel, Person NewPerson);
    }
}
