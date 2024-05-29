using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.DtoValidators;

public class CreateLocationPickingTypeDtoValidator : AbstractValidator<CreateLocationPickingTypeDto>
{
    public CreateLocationPickingTypeDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.PickingTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
