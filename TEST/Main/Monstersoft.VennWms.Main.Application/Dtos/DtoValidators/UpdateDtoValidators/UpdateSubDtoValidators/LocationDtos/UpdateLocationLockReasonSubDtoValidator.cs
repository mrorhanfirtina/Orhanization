using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LocationDtos;

public class UpdateLocationLockReasonSubDtoValidator : AbstractValidator<UpdateLocationLockReasonSubDto>
{
    public UpdateLocationLockReasonSubDtoValidator()
    {
        RuleFor(p => p.LockReasonId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
