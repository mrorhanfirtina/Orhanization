using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.DtoValidators;

public class CreateUnitConversionSubDtoValidator : AbstractValidator<CreateUnitConversionSubDto>
{
    public CreateUnitConversionSubDtoValidator()
    {
        RuleFor(p => p.TargetUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.ConversionRate).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
    }
}
