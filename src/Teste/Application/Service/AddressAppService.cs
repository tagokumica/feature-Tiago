using System;
using System.Collections.Generic;
using Application.Interface;
using Application.ViewModel;
using AutoMapper;
using Domain.Entities;
using Domain.Interface.Service;
using Infra.Data.UnitOfWork;

namespace Application.Service
{
    public class AddressAppService : BaseAppService, IAddressAppService
    {
        private readonly IAddressService _iAddressService;
        private readonly IMapper _iMapper;

        public AddressAppService(IUnitOfWork uow, IAddressService iAddressService, IMapper iMapper) : base(uow)
        {
            _iAddressService = iAddressService;
            _iMapper = iMapper;
        }

        public void Dispose()
        {
            _iAddressService.Dispose();
            GC.SuppressFinalize(this);
        }

        public AddressViewModel FindbyId(Guid id)
        {
            return _iMapper.Map<AddressViewModel>(_iAddressService.FindbyId(id));
        }

        public void DeleteAddressbyCustomer(Guid id)
        {
            try
            {
                _iAddressService.DeleteAddressbyCustomer(id);
                base.Commit();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public AddressViewModel Insert(AddressViewModel addressViewModel)
        {
            var address = _iMapper.Map<Address>(addressViewModel);

            var addessReturn = _iAddressService.Insert(address);
            base.Commit();
            return _iMapper.Map<AddressViewModel>(addessReturn);
        }

        public IEnumerable<AddressViewModel> GetAll()
        {
            return _iMapper.Map<IEnumerable<AddressViewModel>>(_iAddressService.GetAll());
        }

        public AddressViewModel Update(AddressViewModel addressViewModel)
        {
            var address = _iMapper.Map<Address>(addressViewModel);

            var addessReturn = _iAddressService.Update(address);
            base.Commit();
            return _iMapper.Map<AddressViewModel>(addessReturn);
        }
    }
}