using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.DtoValidators;

public class CreateLocationZoneDtoValidator : AbstractValidator<CreateLocationZoneDto>
{
    public CreateLocationZoneDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ZoneId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}



