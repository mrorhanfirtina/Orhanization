using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Validators;

public class DeleteLocationProductConstraintValidator : AbstractValidator<DeleteLocationProductConstraintCommand>
{
    public DeleteLocationProductConstraintValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

