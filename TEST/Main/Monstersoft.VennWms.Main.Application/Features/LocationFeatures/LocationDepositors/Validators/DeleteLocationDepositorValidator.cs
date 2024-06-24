using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Validators;

public class DeleteLocationDepositorValidator : AbstractValidator<DeleteLocationDepositorCommand>
{
    public DeleteLocationDepositorValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

