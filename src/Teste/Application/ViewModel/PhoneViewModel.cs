using System;

namespace Application.ViewModel
{
    public class PhoneViewModel
    {
        public PhoneViewModel()
        {
            PhoneID = Guid.NewGuid();
        }
        public Guid PhoneID { get; set; }
        public Guid CustomerID { get; set; }
        public int Number { get; set; }
        public CustomerViewModel CustomerViewModel { get; set; }

    }
}