using System;
using System.Collections.Generic;
using Application.ViewModel;

namespace Application.Interface
{
    public interface ICustomerAppService : IDisposable
    {
        IEnumerable<CustomerViewModel> GetCustomerbyAddress(Guid id);
        IEnumerable<CustomerViewModel> GetCustomerbyPhone(Guid id);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel Insert(CustomerViewModel customerViewModel);
        CustomerViewModel Update(CustomerViewModel customerViewModel);
        CustomerViewModel FindbyId(Guid id);
        CustomerViewModel FindCustomer(Guid id);

    }
}