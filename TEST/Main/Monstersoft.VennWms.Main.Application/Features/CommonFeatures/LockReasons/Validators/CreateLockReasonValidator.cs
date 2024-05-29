using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Validators;

public class CreateLockReasonValidator : AbstractValidator<CreateLockReasonCommand>
{
    public CreateLockReasonValidator()
    {
        RuleFor(x => x.LockReason).SetValidator(new CreateLockReasonDtoValidator());
    }
}
