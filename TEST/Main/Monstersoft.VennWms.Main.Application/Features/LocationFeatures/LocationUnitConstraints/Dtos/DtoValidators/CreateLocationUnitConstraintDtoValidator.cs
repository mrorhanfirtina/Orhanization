using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.DtoValidators;

public class CreateLocationUnitConstraintDtoValidator : AbstractValidator<CreateLocationUnitConstraintDto>
{
    public CreateLocationUnitConstraintDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.UnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Capacity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
    }
}
