using System;
using System.Collections.Generic;
using Application.ViewModel;

namespace Application.Interface
{
    public interface IPhoneAppService: IDisposable
    {
        IEnumerable<PhoneViewModel> GetAll();
        PhoneViewModel Insert(PhoneViewModel phoneViewModel);
        PhoneViewModel Update(PhoneViewModel phoneViewModel);
        PhoneViewModel FindbyId(Guid id);
        void DeletePhonebyCustomer(Guid id);

    }
}