using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LocationDtos;

public class CreateLocationZoneSubDtoValidator : AbstractValidator<CreateLocationZoneSubDto>
{
    public CreateLocationZoneSubDtoValidator()
    {
        RuleFor(p => p.ZoneId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
