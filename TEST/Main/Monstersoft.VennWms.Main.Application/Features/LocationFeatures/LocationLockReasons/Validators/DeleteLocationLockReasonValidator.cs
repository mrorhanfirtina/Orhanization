using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Validators;

public class DeleteLocationLockReasonValidator : AbstractValidator<DeleteLocationLockReasonCommand>
{
    public DeleteLocationLockReasonValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


