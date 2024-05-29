using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Validators;

public class CreateLocationLockReasonValidator : AbstractValidator<CreateLocationLockReasonCommand>
{
    public CreateLocationLockReasonValidator()
    {
        RuleFor(x => x.LocationLockReason).SetValidator(new CreateLocationLockReasonDtoValidator());
    }
}


