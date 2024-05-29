using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateItemUnitValidator : AbstractValidator<CreateItemUnitCommand>
{
    public CreateItemUnitValidator()
    {
        RuleFor(x => x.ItemUnit).SetValidator(new CreateItemUnitDtoValidator());
    }
}
