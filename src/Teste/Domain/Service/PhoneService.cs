using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interface.Repository;
using Domain.Interface.Service;

namespace Domain.Service
{
    public class PhoneService: IPhoneService
    {
        private readonly IPhoneRepository _iPhoneRepository;

        public PhoneService(IPhoneRepository iPhoneRepository)
        {
            _iPhoneRepository = iPhoneRepository;
        }
        public void Dispose()
        {
            _iPhoneRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Phone> GetAll()
        {
            return _iPhoneRepository.GetAll();
        }

        public Phone Insert(Phone phone)
        {
            return _iPhoneRepository.Insert(phone);
        }

        public Phone Update(Phone phone)
        {
            return _iPhoneRepository.Update(phone);
        }

        public Phone FindbyId(Guid id)
        {
            return _iPhoneRepository.FindbyId(id);
        }

        public void DeletePhonebyCustomer(Guid id)
        {
            _iPhoneRepository.DeletePhonebyCustomer(id);
        }
    }
}