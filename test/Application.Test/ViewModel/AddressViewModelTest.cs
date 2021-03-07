using Application.ViewModel;
using System;
using Application.ViewModel.Validation;
using Xunit;

namespace Application.Test.ViewModel
{
    public class AddressViewModelTest
    {
        [Fact(DisplayName = "Validar Endere�o � V�lido")]
        [Trait("Categoria", "Endere�o")]
        public void Address_Validate_isValid()
        {
            // Arrange
            var expectedIsValid = true;
            var address = new AddressViewModel()
            {
                CustomerID = Guid.NewGuid(),
                AddressID = Guid.NewGuid(),
                City = "S�o Paulo",
                Country = "Brasil",
                Number = 14,
                State = "S�o Paulo",
                Street = "Rua Fulano de Tal",
                Zipcode = "1111111"
            };

            // Act
            var addressValidation = new AddressValidation();
            var validationResult = addressValidation.Validate(address);

            // Assert
            Assert.Equal(expectedIsValid, validationResult.IsValid);
        }


        [Fact(DisplayName = "Validar Endere�o n�o Est� V�lido")]
        [Trait("Categoria", "Endere�o")]
        public void Address_Validate_isNotValid()
        {
            // Arrange
            var expectedIsValid = false;
            var address = new AddressViewModel()
            {
                CustomerID = Guid.Empty,
                AddressID = Guid.Empty,
                City = "S�o",
                Country = "Br",
                Number = 1,
                State = "S�o",
                Street = "Rua",
                Zipcode = "1111111"
            };

            // Act
            var addressValidation = new AddressValidation();
            var validationResult = addressValidation.Validate(address);

            // Assert
            Assert.Equal(expectedIsValid, validationResult.IsValid);
        }

    }
}
