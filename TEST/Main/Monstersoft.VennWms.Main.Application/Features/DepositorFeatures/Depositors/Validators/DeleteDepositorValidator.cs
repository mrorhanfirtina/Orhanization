using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Validators;

public class DeleteDepositorValidator : AbstractValidator<DeleteDepositorCommand>
{
    public DeleteDepositorValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
