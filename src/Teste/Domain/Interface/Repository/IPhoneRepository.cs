using System;
using Domain.Entities;

namespace Domain.Interface.Repository
{
    public interface IPhoneRepository : IRepository<Phone>
    {
        void DeletePhonebyCustomer(Guid id);

    }
}