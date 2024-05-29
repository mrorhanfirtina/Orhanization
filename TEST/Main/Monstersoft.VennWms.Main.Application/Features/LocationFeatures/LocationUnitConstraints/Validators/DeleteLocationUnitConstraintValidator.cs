using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Validators;

public class DeleteLocationUnitConstraintValidator : AbstractValidator<DeleteLocationUnitConstraintCommand>
{
    public DeleteLocationUnitConstraintValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

