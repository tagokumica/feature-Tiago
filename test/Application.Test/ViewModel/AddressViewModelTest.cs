using Application.ViewModel;
using System;
using Application.ViewModel.Validation;
using Xunit;

namespace Application.Test.ViewModel
{
    public class AddressViewModelTest
    {
        [Fact(DisplayName = "Validar Endereço é Válido")]
        [Trait("Categoria", "Endereço")]
        public void Address_Validate_isValid()
        {
            // Arrange
            var expectedIsValid = true;
            var address = new AddressViewModel()
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

            // Act
            var addressValidation = new AddressValidation();
            var validationResult = addressValidation.Validate(address);

            // Assert
            Assert.Equal(expectedIsValid, validationResult.IsValid);
        }


        [Fact(DisplayName = "Validar Endereço não Está Válido")]
        [Trait("Categoria", "Endereço")]
        public void Address_Validate_isNotValid()
        {
            // Arrange
            var expectedIsValid = false;
            var address = new AddressViewModel()
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

            // Act
            var addressValidation = new AddressValidation();
            var validationResult = addressValidation.Validate(address);

            // Assert
            Assert.Equal(expectedIsValid, validationResult.IsValid);
        }

    }
}
