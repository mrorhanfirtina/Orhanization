using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateItemUnitValidator : AbstractValidator<CreateItemUnitCommand>
{
    public CreateItemUnitValidator()
    {
        RuleFor(x => x.ItemUnit).SetValidator(new CreateItemUnitDtoValidator());
    }
}
