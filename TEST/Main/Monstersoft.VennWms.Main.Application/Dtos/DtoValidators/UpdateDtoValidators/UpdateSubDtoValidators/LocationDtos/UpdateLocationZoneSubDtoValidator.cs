using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LocationDtos;

public class UpdateLocationZoneSubDtoValidator : AbstractValidator<UpdateLocationZoneSubDto>
{
    public UpdateLocationZoneSubDtoValidator()
    {
        RuleFor(p => p.ZoneId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
