using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.DtoValidators;

public class CreateLocationPickingTypeSubDtoValidator : AbstractValidator<CreateLocationPickingTypeSubDto>
{
    public CreateLocationPickingTypeSubDtoValidator()
    {
        RuleFor(p => p.PickingTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
