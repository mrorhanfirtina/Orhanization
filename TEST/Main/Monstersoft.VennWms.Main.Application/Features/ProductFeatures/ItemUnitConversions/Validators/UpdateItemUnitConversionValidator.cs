using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Validators;

public class UpdateItemUnitConversionValidator : AbstractValidator<UpdateItemUnitConversionCommand>
{
    public UpdateItemUnitConversionValidator()
    {
        RuleFor(x => x.ItemUnitConversion).SetValidator(new UpdateItemUnitConversionDtoValidator());
    }
}
