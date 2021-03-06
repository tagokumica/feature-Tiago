using System;
using Domain.Enum;

namespace Domain.Entities
{
    public class Phone
    {
        public Phone()
        {
            PhoneID = Guid.NewGuid();
        }
        public Guid PhoneID { get; set; }
        public Guid CustomerID { get; set; }
        public int Number { get; set; }
        public TypePhone TypePhone { get; set; }

        public Customer Customer { get; set; }

    }
}