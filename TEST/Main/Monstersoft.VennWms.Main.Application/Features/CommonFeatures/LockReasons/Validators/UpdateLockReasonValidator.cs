using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Validators;

public class UpdateLockReasonValidator : AbstractValidator<UpdateLockReasonCommand>
{
    public UpdateLockReasonValidator()
    {
        RuleFor(x => x.LockReason).SetValidator(new UpdateLockReasonDtoValidator());
    }
}
