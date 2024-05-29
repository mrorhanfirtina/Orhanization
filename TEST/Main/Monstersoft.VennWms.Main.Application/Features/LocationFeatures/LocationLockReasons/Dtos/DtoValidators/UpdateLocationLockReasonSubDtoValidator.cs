using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.DtoValidators;

public class UpdateLocationLockReasonSubDtoValidator : AbstractValidator<UpdateLocationLockReasonSubDto>
{
    public UpdateLocationLockReasonSubDtoValidator()
    {
        RuleFor(p => p.LockReasonId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
