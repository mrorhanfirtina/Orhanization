using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Validators;

public class DeleteDepositorCompanyValidator : AbstractValidator<DeleteDepositorCompanyCommand>
{
    public DeleteDepositorCompanyValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
