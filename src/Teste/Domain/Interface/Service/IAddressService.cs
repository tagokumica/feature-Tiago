using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface.Service
{
    public interface IAddressService : IDisposable
    {
        IEnumerable<Address> GetAll();
        Address Insert(Address address);
        Address Update(Address address);
        Address FindbyId(Guid id);
        void DeleteAddressbyCustomer(Guid id);

    }
}