using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Validators;

public class DeleteDistributorValidator : AbstractValidator<DeleteDistributorCommand>
{
    public DeleteDistributorValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
