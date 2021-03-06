using System;

namespace Application.ViewModel
{
    public class AddressViewModel
    {
        public AddressViewModel()
        {
            AddressID = Guid.NewGuid();
        }
        public Guid AddressID { get; set; }
        public Guid CustomerID { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public CustomerViewModel CustomerViewModel { get; set; }


        
    }
}