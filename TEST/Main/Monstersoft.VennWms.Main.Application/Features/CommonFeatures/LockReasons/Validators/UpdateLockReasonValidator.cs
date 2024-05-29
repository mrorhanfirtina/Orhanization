using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Validators;

public class UpdateLockReasonValidator : AbstractValidator<UpdateLockReasonCommand>
{
    public UpdateLockReasonValidator()
    {
        RuleFor(x => x.LockReason).SetValidator(new UpdateLockReasonDtoValidator());
    }
}
