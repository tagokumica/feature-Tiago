using FluentValidation;

namespace Application.ViewModel.Validation
{
    public class CustomerValidation : AbstractValidator<CustomerViewModel>
    {
        public CustomerValidation()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage("O campo Nome deve ser preenchido")
                .Length(5, 50)
                .WithMessage("O campo Nome deve ter entre {MinLength} e {MaxLength} caracteres")
                .Matches(@"^[a-zA-Z''-'\s]{1,40}$")
                .WithMessage("Números e caracteres especiais não são permitidos no Nome.");



            RuleFor(s => s.Email)
                .NotEmpty()
                .WithMessage("Email deve ser preenchido")
                .Length(5, 40)
                .WithMessage("O campo Nome deve ter entre {MinLength} e {MaxLength} caracteres")
                .EmailAddress()
                .WithMessage("A validação Email é requirida");
        }
    }
}
