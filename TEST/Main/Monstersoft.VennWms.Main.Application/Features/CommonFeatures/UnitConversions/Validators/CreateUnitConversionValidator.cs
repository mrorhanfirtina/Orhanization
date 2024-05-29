using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Validators;

public class CreateUnitConversionValidator : AbstractValidator<CreateUnitConversionCommand>
{
    public CreateUnitConversionValidator()
    {
        RuleFor(x => x.UnitConversion).SetValidator(new CreateUnitConversionDtoValidator());
    }
}
