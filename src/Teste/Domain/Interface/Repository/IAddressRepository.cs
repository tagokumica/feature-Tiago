using System;
using Domain.Entities;

namespace Domain.Interface.Repository
{
    public interface IAddressRepository : IRepository<Address>
    {
        void DeleteAddressbyCustomer(Guid id);

    }
}