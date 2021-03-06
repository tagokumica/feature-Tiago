using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface.Service
{
    public interface ICustomerService : IDisposable
    {
        IEnumerable<Customer> GetCustomerbyAddress(Guid id);
        IEnumerable<Customer> GetCustomerbyPhone(Guid id);
        IEnumerable<Customer> GetAll();
        Customer Insert(Customer customer);
        Customer Update(Customer customer);
        Customer FindbyId(Guid id);
        Customer FindCustomer(Guid id);

    }
}