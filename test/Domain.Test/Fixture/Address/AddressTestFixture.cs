using System;
using System.Collections.Generic;

namespace Domain.Test.Fixture.Address
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


        public IEnumerable<Entities.Address> GetAddresses()
        {

            var addresses = new List<Entities.Address>
            {
                new Entities.Address()
                {
                    CustomerID = Guid.Empty,
                    AddressID = Guid.Empty,
                    City = "São Paulo",
                    Country = "Br",
                    Number = 1,
                    State = "São",
                    Street = "Rua",
                    Zipcode = "1111111"
                },

                new Entities.Address()
                {
                    CustomerID = Guid.Empty,
                    AddressID = Guid.Empty,
                    City = "São Luiz",
                    Country = "Br",
                    Number = 1,
                    State = "Maranhão",
                    Street = "Rua",
                    Zipcode = "1111111"

                }
            };


            return addresses;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}