using FluentValidation;

namespace Application.ViewModel.Validation
{
    public class AddressValidation : AbstractValidator<AddressViewModel>
    {
        public AddressValidation()
        {
            RuleFor(s => s.Street)
                .NotEmpty()
                .WithMessage("O campo Rua deve ser preenchido")
                .Length(5, 50)
                .WithMessage("O campo Rua deve ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(s => s.Number)
                .NotEmpty()
                .WithMessage("O campo Numero deve ser preenchido");

            RuleFor(s => s.Zipcode)
                .NotEmpty()
                .WithMessage("O campo CEP deve ser preenchido");

            RuleFor(s => s.City)
                .NotEmpty()
                .WithMessage("O campo Cidade deve ser preenchido")
                .Length(5, 50)
                .WithMessage("O campo Cidade deve ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(s => s.State)
                .NotEmpty()
                .WithMessage("O campo Estado deve ser preenchido")
                .Length(5, 50)
                .WithMessage("O campo Estado deve ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(s => s.Country)
                .NotEmpty()
                .WithMessage("O campo Pais deve ser preenchido")
                .Length(5, 50)
                .WithMessage("O campo Pais deve ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}