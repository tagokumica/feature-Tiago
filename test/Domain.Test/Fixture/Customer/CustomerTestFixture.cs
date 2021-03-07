using System;
using System.Collections.Generic;

namespace Domain.Test.Fixture.Customer
{
    public class CustomerTestFixture : IDisposable
    {
     

            public Entities.Customer GenerateCustomerValid()
            {
                var customer = new Entities.Customer()
                {
                    CustomerID = Guid.NewGuid(),
                    Name = "Tiago",
                    Email = "teste@teste"
                };

                return customer;
            }

            public Entities.Customer GenerateCustomerInvalid()
            {
                var customer = new Entities.Customer()
                {
                    CustomerID = Guid.Empty,
                    Name = "",
                    Email = ""
                };

                return customer;
            }
            public IEnumerable<Entities.Customer> GetCustomers()
            {

                var customer = new List<Entities.Customer>
                {
                    new Entities.Customer()
                    {
                        CustomerID = Guid.NewGuid(),
                        Name = "Tiago",
                        Email = "tiago_tanp@teste.com"
                    },

                    new Entities.Customer()
                    {
                        CustomerID = Guid.NewGuid(),
                        Name = "Diego",
                        Email = "teste@teste.com"

                    }
                };


                return customer;
            }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}