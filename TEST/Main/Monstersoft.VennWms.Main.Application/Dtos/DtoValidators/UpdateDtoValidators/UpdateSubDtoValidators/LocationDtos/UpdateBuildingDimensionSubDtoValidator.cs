using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LocationDtos;

public class UpdateBuildingDimensionSubDtoValidator : AbstractValidator<UpdateBuildingDimensionSubDto>
{
    public UpdateBuildingDimensionSubDtoValidator()
    {
        RuleFor(p => p.LenghtUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.BuildingLevel).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Width).PrecisionScale(18, 6, false);
        RuleFor(p => p.Height).PrecisionScale(18, 6, false);
        RuleFor(p => p.Length).PrecisionScale(18, 6, false);
        RuleFor(p => p.VolumeUnitId).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Volume).PrecisionScale(18, 6, false);
    }
}
