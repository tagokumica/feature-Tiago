using System;
using System.Collections.Generic;
using Application.ViewModel;

namespace Application.Interface
{
    public interface IAddressAppService : IDisposable
    {
        IEnumerable<AddressViewModel> GetAll();
        AddressViewModel Insert(AddressViewModel addressViewModel);
        AddressViewModel Update(AddressViewModel addressViewModel);
        AddressViewModel FindbyId(Guid id);
        void DeleteAddressbyCustomer(Guid id);

    }
}