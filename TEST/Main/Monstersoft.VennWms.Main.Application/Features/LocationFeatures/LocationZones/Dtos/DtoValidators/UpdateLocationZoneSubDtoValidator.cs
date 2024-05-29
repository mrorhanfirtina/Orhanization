using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.DtoValidators;

public class UpdateLocationZoneSubDtoValidator : AbstractValidator<UpdateLocationZoneSubDto>
{
    public UpdateLocationZoneSubDtoValidator()
    {
        RuleFor(p => p.ZoneId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
