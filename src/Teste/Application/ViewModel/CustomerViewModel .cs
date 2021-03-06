using System;
using System.Collections.Generic;

namespace Application.ViewModel
{
    public class CustomerViewModel
    {

        public CustomerViewModel()
        {
            CustomerID = Guid.NewGuid();
            AddressViewModel = new List<AddressViewModel>();
            PhoneViewModel = new List<PhoneViewModel>();
        }

        public Guid CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Phone { get; set; }
        public IEnumerable<PhoneViewModel> PhoneViewModel { get; set; }

        public IEnumerable<AddressViewModel> AddressViewModel { get; set; }
    }
}