using System;

namespace Domain.Test.Fixture.Customer
{
    public class AddressTestFixture : IDisposable
    {


        public Entities.Address GenerateAddressValid()
        {
            var address = new Entities.Address()
            {
                CustomerID = Guid.NewGuid(),
                AddressID = Guid.NewGuid(),
                City = "São Paulo",
                Country = "Brasil",
                Number = 14,
                State = "São Paulo",
                Street = "Rua Fulano de Tal",
                Zipcode = "1111111"
            };

            return address;
        }

        public Entities.Address GenerateAddressInvalid()
        {
            var address = new Entities.Address()
            {
                CustomerID = Guid.Empty,
                AddressID = Guid.Empty,
                City = "São",
                Country = "Br",
                Number = 1,
                State = "São",
                Street = "Rua",
                Zipcode = "1111111"
            };

            return address;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}