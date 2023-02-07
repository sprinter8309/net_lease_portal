using SearchNavigator.Data.Entities;
using SearchNavigator.Data.Interfaces.Factories;
using SearchNavigator.Models;

namespace SearchNavigator.Factories
{
    public class LeaseFactory : ILeaseFactory
    {
        public Lease CreateLease(CarLeaseRequestModel carLeaseReqestModel, Person NewPerson)
        {
            Lease NewLease = new Lease();

            NewLease.PersonId = NewPerson.Id;
            NewLease.CarId = carLeaseReqestModel.CarId;
            NewLease.CreatedAt = DateTime.Now;
            NewLease.DeletedAt = null;

            return NewLease;
        }
    }
}
