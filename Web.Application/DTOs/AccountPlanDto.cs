using FluentValidation;

namespace Web.Application.DTOs
{
    public class AccountPlanDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool AcceptsLaunches { get; set; }
    }

    public class AccountPlanDtoRequestValidator : AbstractValidator<AccountPlanDto>
    {
        public AccountPlanDtoRequestValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Code é obrigatório")
                .MaximumLength(100).WithMessage("Nome deve ter no máximo 100 caracteres")
                .MinimumLength(1).WithMessage("Nome deve ter no mínimo 3 caracteres");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nome é obrigatório")
                .MaximumLength(100).WithMessage("Nome passou de 100 caracteres");                

        }
    }
}