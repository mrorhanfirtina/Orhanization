using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Validators;

public class DeleteLockReasonValidator : AbstractValidator<DeleteLockReasonCommand>
{
    public DeleteLockReasonValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
