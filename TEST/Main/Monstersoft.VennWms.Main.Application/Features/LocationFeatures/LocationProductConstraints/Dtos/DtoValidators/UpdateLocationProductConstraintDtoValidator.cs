using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.DtoValidators;

public class UpdateLocationProductConstraintDtoValidator : AbstractValidator<UpdateLocationProductConstraintDto>
{
    public UpdateLocationProductConstraintDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Capacity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.ReplenishmentTreshold).PrecisionScale(18, 6, false);
        RuleFor(p => p.ExceedCapacityMargin).PrecisionScale(18, 6, false);
    }
}

