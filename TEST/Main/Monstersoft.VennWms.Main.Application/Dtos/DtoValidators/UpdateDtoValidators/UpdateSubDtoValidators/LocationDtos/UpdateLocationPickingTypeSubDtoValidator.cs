using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LocationDtos;

public class UpdateLocationPickingTypeSubDtoValidator : AbstractValidator<UpdateLocationPickingTypeSubDto>
{
    public UpdateLocationPickingTypeSubDtoValidator()
    {
        RuleFor(p => p.PickingTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
