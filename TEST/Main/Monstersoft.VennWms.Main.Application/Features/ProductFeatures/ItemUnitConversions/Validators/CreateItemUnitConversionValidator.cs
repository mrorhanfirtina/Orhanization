using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Validators;

public class CreateItemUnitConversionValidator : AbstractValidator<CreateItemUnitConversionCommand>
{
    public CreateItemUnitConversionValidator()
    {
        RuleFor(x => x.ItemUnitConversion).SetValidator(new CreateItemUnitConversionDtoValidator());
    }
}
