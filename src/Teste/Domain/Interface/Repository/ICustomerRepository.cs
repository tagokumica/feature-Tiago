using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interface.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetCustomerbyAddress(Guid id);
        IEnumerable<Customer> GetCustomerbyPhone(Guid id);
        Customer FindCustomer(Guid id);
    }
}