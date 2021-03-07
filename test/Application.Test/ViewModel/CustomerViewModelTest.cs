using System;
using Application.ViewModel;
using Application.ViewModel.Validation;
using Xunit;

namespace Application.Test.ViewModel
{
    public class CustomerViewModelTest
    {
        [Fact(DisplayName = "Validar Cliente é Válido")]
        [Trait("Categoria", "Cliente")]
        public void Customer_Validate_isValid()
        {
            // Arrange
            var expectedIsValid = true;
            var customer = new CustomerViewModel()
            {
                CustomerID = Guid.NewGuid(),
                Name = "Tiago",
                Email = "tiago_tanp@hotmail.com",
            };

            // Act
            var customerValidation = new CustomerValidation();
            var validationResult = customerValidation.Validate(customer);

            // Assert
            Assert.Equal(expectedIsValid, validationResult.IsValid);
        }


        [Fact(DisplayName = "Validar Cliente não é Válido")]
        [Trait("Categoria", "Cliente")]
        public void Customer_Validate_isNotValid()
        {
            // Arrange
            var expectedIsValid = false;
            var customer = new CustomerViewModel()
            {
                CustomerID = Guid.NewGuid(),
                Name = "Tiago",
                Email = "tiago_tanphotmail.com",
            };

            // Act
            var customerValidation = new CustomerValidation();
            var validationResult = customerValidation.Validate(customer);

            // Assert
            Assert.Equal(expectedIsValid, validationResult.IsValid);
        }



    }
}