using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.DtoValidators;

public class CreateLocationCoordinateDtoValidator : AbstractValidator<CreateLocationCoordinateDto>
{
    public CreateLocationCoordinateDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.BuildingId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.LocationX).PrecisionScale(18, 6, false);
        RuleFor(p => p.LocationY).PrecisionScale(18, 6, false);
        RuleFor(p => p.LocationZ).PrecisionScale(18, 6, false);
    }
}
