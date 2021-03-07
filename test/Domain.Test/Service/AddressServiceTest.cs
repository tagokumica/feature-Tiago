using System.Linq;
using Domain.Interface.Repository;
using Domain.Service;
using Domain.Test.Collection.Address;
using Domain.Test.Fixture.Address;
using Moq;
using Xunit;

namespace Domain.Test.Service
{
    [Collection(nameof(AddressCollection))]
    public class AddressServiceTest
    {
        readonly AddressTestFixture _addressTestFixture;

        public AddressServiceTest(AddressTestFixture addressTestFixture)
        {
            _addressTestFixture = addressTestFixture;
        }

        [Fact(DisplayName = "Adicionar Endereço com Sucesso")]
        [Trait("Categoria", "Endereço Service  Tests")]
        public void AddressService_Insert_Success()
        {
            // Arrange
            var address = _addressTestFixture.GenerateAddressValid();
            var addressRepo = new Mock<IAddressRepository>();

            var addressService = new AddressService(addressRepo.Object);

            // Act
            addressService.Insert(address);

            // Assert
            addressRepo.Verify(r => r.Insert(address), Times.Once);
        }


        [Fact(DisplayName = "Adicionar Endereço com Falha")]
        [Trait("Categoria", "Endereço Service Tests")]
        public void AddressService_Insert_Failed()
        {
            // Arrange
            var address = _addressTestFixture.GenerateAddressInvalid();
            var addressRepo = new Mock<IAddressRepository>();

            var addressService = new AddressService(addressRepo.Object);


            // Act
            addressService.Insert(address);

            // Assert
            addressRepo.Verify(r => r.Insert(address), Times.Once);
        }


        [Fact(DisplayName = "Obter Endereço ")]
        [Trait("Categoria", "Endereço Service Tests")]
        public void AddressService_GetAll_Return()
        {
            // Arrange
            var addresses = _addressTestFixture.GetAddresses();
            var addressRepo = new Mock<IAddressRepository>();

            addressRepo.Setup(c => c.GetAll())
                .Returns(addresses);

            var addressService = new AddressService(addressRepo.Object);

            // Act
            var address = addressService.GetAll();

            // Assert 
            addressRepo.Verify(r => r.GetAll(), Times.Once);
            Assert.True(address.Any());
        }


    }
}