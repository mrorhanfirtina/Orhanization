using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.DtoValidators;

public class UpdateLocationDimensionSubDtoValidator : AbstractValidator<UpdateLocationDimensionSubDto>
{
    public UpdateLocationDimensionSubDtoValidator()
    {
        RuleFor(p => p.Width).PrecisionScale(18, 6, false);
        RuleFor(p => p.Height).PrecisionScale(18, 6, false);
        RuleFor(p => p.Length).PrecisionScale(18, 6, false);
        RuleFor(p => p.LengthUnitId).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Volume).PrecisionScale(18, 6, false);
        RuleFor(p => p.VolumeUnitId).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.MaxWeight).PrecisionScale(18, 6, false);
        RuleFor(p => p.WeightUnitId).InclusiveBetween(0, int.MaxValue);
    }
}
