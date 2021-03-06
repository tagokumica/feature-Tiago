using Domain.Entities;
using Domain.Interface.Repository;
using Infra.Data.Context;
using System;
using System.Linq;

namespace Infra.Data.Repository
{
    public class AddressRepository: Repository<Address>, IAddressRepository
    {
        public AddressRepository(TesteContext context) : base(context)
        {
        }

        public void DeleteAddressbyCustomer(Guid id)
        {
            testeContext.Address.Remove(testeContext.Address.First(c => c.CustomerID == id));
        }
    }
}