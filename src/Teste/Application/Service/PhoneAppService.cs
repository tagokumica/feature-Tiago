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
    public class PhoneAppService : BaseAppService, IPhoneAppService
    {
        private readonly IPhoneService _iPhoneService;
        private readonly IMapper _iMapper;

        public PhoneAppService(IUnitOfWork uow, IPhoneService iPhoneService, IMapper iMapper) : base(uow)
        {
            _iPhoneService = iPhoneService;
            _iMapper = iMapper;
        }
     

        public void Dispose()
        {
            _iPhoneService.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<PhoneViewModel> GetAll()
        {
            return _iMapper.Map<IEnumerable<PhoneViewModel>>(_iPhoneService.GetAll());
        }

        public PhoneViewModel Insert(PhoneViewModel phoneViewModel)
        {
            var phone = _iMapper.Map<Phone>(phoneViewModel);

            var phoneReturn = _iPhoneService.Insert(phone);
            base.Commit();
            return _iMapper.Map<PhoneViewModel>(phoneReturn);
        }

        public PhoneViewModel Update(PhoneViewModel phoneViewModel)
        {
            var phone = _iMapper.Map<Phone>(phoneViewModel);

            var phoneReturn = _iPhoneService.Update(phone);
            base.Commit();
            return _iMapper.Map<PhoneViewModel>(phoneReturn);
        }

        public PhoneViewModel FindbyId(Guid id)
        {
            return _iMapper.Map<PhoneViewModel>(_iPhoneService.FindbyId(id));
        }

        public void DeletePhonebyCustomer(Guid id)
        {
            try
            {
                _iPhoneService.DeletePhonebyCustomer(id);
                base.Commit();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}