using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.DtoValidators;

public class CreateLocationZoneSubDtoValidator : AbstractValidator<CreateLocationZoneSubDto>
{
    public CreateLocationZoneSubDtoValidator()
    {
        RuleFor(p => p.ZoneId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
