using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Validators;

public class UpdateLocationLockReasonValidator : AbstractValidator<UpdateLocationLockReasonCommand>
{
    public UpdateLocationLockReasonValidator()
    {
        RuleFor(x => x.LocationLockReason).SetValidator(new UpdateLocationLockReasonDtoValidator());
    }
}


