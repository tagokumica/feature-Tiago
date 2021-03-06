using Domain.Entities;
using Domain.Interface.Repository;
using Domain.Interface.Service;
using System;
using System.Collections.Generic;

namespace Domain.Service
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _iCustomerRepository;

        public CustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }
        public void Dispose()
        {
            _iCustomerRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Customer FindbyId(Guid id)
        {
            return _iCustomerRepository.FindbyId(id);
        }

        public Customer FindCustomer(Guid id)
        {
            return _iCustomerRepository.FindCustomer(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _iCustomerRepository.GetAll();
        }

        public IEnumerable<Customer> GetCustomerbyAddress(Guid id)
        {
            return _iCustomerRepository.GetCustomerbyAddress(id);
        }

        public IEnumerable<Customer> GetCustomerbyPhone(Guid id)
        {
            return _iCustomerRepository.GetCustomerbyPhone(id);
        }

        public Customer Insert(Customer customer)
        {
            return _iCustomerRepository.Insert(customer);
        }

        public Customer Update(Customer customer)
        {
            return _iCustomerRepository.Update(customer);
        }
    }
}