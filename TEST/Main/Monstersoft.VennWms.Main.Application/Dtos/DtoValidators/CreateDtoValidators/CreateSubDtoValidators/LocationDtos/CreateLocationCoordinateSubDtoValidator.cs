using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LocationDtos;

public class CreateLocationCoordinateSubDtoValidator : AbstractValidator<CreateLocationCoordinateSubDto>
{
    public CreateLocationCoordinateSubDtoValidator()
    {
        RuleFor(p => p.BuildingId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.LocationX).PrecisionScale(18, 6, false);
        RuleFor(p => p.LocationY).PrecisionScale(18, 6, false);
        RuleFor(p => p.LocationZ).PrecisionScale(18, 6, false);
    }
}
