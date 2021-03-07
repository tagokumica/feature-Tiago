using Domain.Interface.Notification;
using Domain.Interface.Repository;
using Domain.Service;
using Domain.Test.Collection.Customer;
using Domain.Test.Fixture.Customer;
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
        [Trait("Categoria", "Endereço Service Mock Tests")]
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
        [Trait("Categoria", "Endereço Service Mock Tests")]
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




    }
}