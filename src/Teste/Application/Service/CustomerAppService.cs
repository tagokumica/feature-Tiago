using Application.Interface;
using Application.ViewModel;
using Domain.Interface.Service;
using Infra.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using AutoMapper;
using Domain.Entities;

namespace Application.Service
{
    public class CustomerAppService: BaseAppService, ICustomerAppService
    {
        private readonly ICustomerService _iCustomerService;
        private readonly IMapper _iMapper;

        public CustomerAppService(IUnitOfWork uow, ICustomerService iCustomerService, IMapper iMapper) : base(uow)
        {
            _iCustomerService = iCustomerService;
            _iMapper = iMapper;
        }

        public void Dispose()
        {
            _iCustomerService.Dispose();
            GC.SuppressFinalize(this);
        }

        public CustomerViewModel FindbyId(Guid id)
        {
            return _iMapper.Map<CustomerViewModel>(_iCustomerService.FindbyId(id));
        }

        public CustomerViewModel FindCustomer(Guid id)
        {
            return _iMapper.Map<CustomerViewModel>(_iCustomerService.FindCustomer(id));
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            return _iMapper.Map<IEnumerable<CustomerViewModel>>(_iCustomerService.GetAll());
        }

        public IEnumerable<CustomerViewModel> GetCustomerbyAddress(Guid id)
        {
            return _iMapper.Map<IEnumerable<CustomerViewModel>>(_iCustomerService.GetCustomerbyAddress(id));
        }

        public IEnumerable<CustomerViewModel> GetCustomerbyPhone(Guid id)
        {
            return _iMapper.Map<IEnumerable<CustomerViewModel>>(_iCustomerService.GetCustomerbyPhone(id));
        }

        public CustomerViewModel Insert(CustomerViewModel customerViewModel)
        {
            var customer = _iMapper.Map<Customer>(customerViewModel);

            var customerReturn = _iCustomerService.Insert(customer);
            base.Commit();
            return _iMapper.Map<CustomerViewModel>(customerReturn);
        }

        public CustomerViewModel Update(CustomerViewModel customerViewModel)
        {
            var customer = _iMapper.Map<Customer>(customerViewModel);

            var customerReturn = _iCustomerService.Update(customer);
            base.Commit();
            return _iMapper.Map<CustomerViewModel>(customerReturn);
        }
    }
}