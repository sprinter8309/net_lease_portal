using SearchNavigator.Data.Entities;
using SearchNavigator.Data.Interfaces.Factories;
using SearchNavigator.Models;

namespace SearchNavigator.Factories
{
    public class PersonFactory : IPersonFactory
    {
        public Person CreatePersonLeaseRequest(CarLeaseRequestModel carLeaseReqestModel)
        {
            Person NewPerson = new Person();

            NewPerson.Name = carLeaseReqestModel.PersonName;
            NewPerson.Phone = carLeaseReqestModel.PersonPhone;
            NewPerson.Email = carLeaseReqestModel.PersonEmail;
            NewPerson.PassportNumber = carLeaseReqestModel.PersonPassportNumber;

            return NewPerson;
        }
    }
}
