using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.DtoValidators;

public class UpdateLocationPickingTypeSubDtoValidator : AbstractValidator<UpdateLocationPickingTypeSubDto>
{
    public UpdateLocationPickingTypeSubDtoValidator()
    {
        RuleFor(p => p.PickingTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
