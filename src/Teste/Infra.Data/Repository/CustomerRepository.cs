using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interface.Repository;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(TesteContext context) : base(context)
        {
        }

        public IEnumerable<Customer> GetCustomerbyAddress(Guid id)
        {
            return testeContext
                .Address
                .Include("Customer")
                .Where(s => s.CustomerID == id)
                .Select(s => s.Customer)
                .ToList();

        }

        public IEnumerable<Customer> GetCustomerbyPhone(Guid id)
        {
            return testeContext
                .Phone
                .Include("Customer")
                .Where(s => s.CustomerID == id)
                .Select(s => s.Customer)
                .ToList();

        }

        public Customer FindCustomer(Guid id)
        {
            return DbSet.Include("Phone")
                .Include("Address")
                .FirstOrDefault(s => s.CustomerID == id);
        }
    }
}