using SearchNavigator.Data.Interfaces.Services;
using SearchNavigator.Data.Entities;
using SearchNavigator.Data.Interfaces.Repositories;
using SearchNavigator.Models.DTO;
using SearchNavigator.Repositories;
using SearchNavigator.Models;
using SearchNavigator.Factories;
using SearchNavigator.Data.Interfaces.Factories;

namespace SearchNavigator.Services
{
    public class LeaseService : ILeaseService
    {
        private readonly ILeaseRepository _leaseRepository;
        private readonly IPersonRepository _personRepository;
        private readonly ILeaseFactory _leaseFactory;
        private readonly IPersonFactory _personFactory;

        public LeaseService(ILeaseRepository LeaseRepository, ILeaseFactory LeaseFactory,
                            IPersonFactory PersonFactory, IPersonRepository personRepository)
        {
            _leaseRepository = LeaseRepository;
            _leaseFactory = LeaseFactory;
            _personFactory = PersonFactory;
            _personRepository = personRepository;       
        }

        public IEnumerable<LeaseShortInfoDTO> GetActualLeases()
        {
            return _leaseRepository.GetActualLeases();
        }

        public bool CreateNewLease(CarLeaseRequestModel carLeaseRequestModel)
        {
            Person NewPerson = _personFactory.CreatePersonLeaseRequest(carLeaseRequestModel);
            _personRepository.SavePersonRecord(NewPerson);

            Lease NewLease = _leaseFactory.CreateLease(carLeaseRequestModel, NewPerson);
            _leaseRepository.SaveLeaseRecord(NewLease);

            return true;
        }
    }
}
