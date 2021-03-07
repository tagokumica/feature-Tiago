using System.Threading;
using Domain.Interface.Notification;
using Domain.Interface.Repository;
using Domain.Service;
using Domain.Test.Collection.Customer;
using Domain.Test.Fixture.Customer;
using Moq;
using Xunit;

namespace Domain.Test.Service
{
    [Collection(nameof(CustomerCollection))]
    public class CustomerServiceTest
    {

        readonly CustomerTestFixture _customerTestFixture;

        public CustomerServiceTest(CustomerTestFixture customerTestFixture)
        {
            _customerTestFixture = customerTestFixture;
        }

        [Fact(DisplayName = "Adicionar Cliente com Sucesso")]
        [Trait("Categoria", "Cliente Service Mock Tests")]
        public void CustomerService_Insert_Success()
        {
            // Arrange
            var customer = _customerTestFixture.GenerateCustomerValid();
            var customerRepo = new Mock<ICustomerRepository>();
            var notification = new Mock<INotification>();

            var customerService = new CustomerService(notification.Object, customerRepo.Object);

            // Act
            customerService.Insert(customer);

            // Assert
            customerRepo.Verify(r => r.Insert(customer), Times.Once);
        }


        [Fact(DisplayName = "Adicionar Cliente com Falha")]
        [Trait("Categoria", "Cliente Service Mock Tests")]
        public void CustomerService_Insert_Failed()
        {
            // Arrange
            var customer = _customerTestFixture.GenerateCustomerInvalid();
            var customerRepo = new Mock<ICustomerRepository>();
            var notification = new Mock<INotification>();

            var customerService = new CustomerService(notification.Object, customerRepo.Object);

            // Act
            customerService.Insert(customer);

            // Assert
            customerRepo.Verify(r => r.Insert(customer), Times.Once);
        }

    }
}
