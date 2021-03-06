using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface.Repository;
using Domain.Interface.Service;

namespace Domain.Service
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _iAddressRepository;

        public AddressService(IAddressRepository iAddressRepository)
        {
            _iAddressRepository = iAddressRepository;
        }

        public void Dispose()
        {
            _iAddressRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Address> GetAll()
        {
            return _iAddressRepository.GetAll();
        }

        public Address Insert(Address address)
        {
            return _iAddressRepository.Insert(address);
        }

        public Address Update(Address address)
        {
            return _iAddressRepository.Update(address);
        }

        public Address FindbyId(Guid id)
        {
            return _iAddressRepository.FindbyId(id);
        }

        public void DeleteAddressbyCustomer(Guid id)
        {
            _iAddressRepository.DeleteAddressbyCustomer(id);
        }
    }
}