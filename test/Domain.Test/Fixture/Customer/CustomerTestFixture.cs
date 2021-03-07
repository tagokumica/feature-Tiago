using System;
using Domain.Entities;
using Xunit.Sdk;

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

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}