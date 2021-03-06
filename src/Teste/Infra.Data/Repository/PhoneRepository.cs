using Domain.Entities;
using Domain.Interface.Repository;
using Infra.Data.Context;
using System;
using System.Linq;

namespace Infra.Data.Repository
{
    public class PhoneRepository : Repository<Phone>, IPhoneRepository
    {
        public PhoneRepository(TesteContext context) : base(context)
        {
        }

        public void DeletePhonebyCustomer(Guid id)
        {
            testeContext.Phone.Remove(testeContext.Phone.First(c => c.CustomerID == id));
        }
    }
}