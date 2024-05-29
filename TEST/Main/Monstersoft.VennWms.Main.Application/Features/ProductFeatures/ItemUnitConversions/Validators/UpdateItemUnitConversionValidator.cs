using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Validators;

public class UpdateItemUnitConversionValidator : AbstractValidator<UpdateItemUnitConversionCommand>
{
    public UpdateItemUnitConversionValidator()
    {
        RuleFor(x => x.ItemUnitConversion).SetValidator(new UpdateItemUnitConversionDtoValidator());
    }
}
