using SearchNavigator.Data.Entities;
using SearchNavigator.Models;

namespace SearchNavigator.Data.Interfaces.Factories
{
    public interface IPersonFactory
    {
        Person CreatePersonLeaseRequest(CarLeaseRequestModel carLeaseReqestModel);
    }
}
