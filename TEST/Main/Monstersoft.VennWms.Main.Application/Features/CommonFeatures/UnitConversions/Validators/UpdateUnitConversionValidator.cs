using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Validators;

public class UpdateUnitConversionValidator : AbstractValidator<UpdateUnitConversionCommand>
{
    public UpdateUnitConversionValidator()
    {
        RuleFor(x => x.UnitConversion).SetValidator(new UpdateUnitConversionDtoValidator());
    }
}
