using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Customer
    {

        public Customer()
        {
            CustomerID = Guid.NewGuid();
            Address = new List<Address>();
            Phone = new List<Phone>();
        }

        public Guid CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public IEnumerable<Address> Address { get; set; }
        public IEnumerable<Phone> Phone { get; set; }
    }
}