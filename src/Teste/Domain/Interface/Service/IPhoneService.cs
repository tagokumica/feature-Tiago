using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface.Service
{
    public interface IPhoneService: IDisposable
    {
        IEnumerable<Phone> GetAll();
        Phone Insert(Phone phone);
        Phone Update(Phone phone);
        Phone FindbyId(Guid id);
        void DeletePhonebyCustomer(Guid id);

    }
}