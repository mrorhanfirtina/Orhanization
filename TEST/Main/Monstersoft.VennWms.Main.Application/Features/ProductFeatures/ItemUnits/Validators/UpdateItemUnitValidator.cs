using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateItemUnitValidator : AbstractValidator<UpdateItemUnitCommand>
{
    public UpdateItemUnitValidator()
    {
        RuleFor(x => x.ItemUnit).SetValidator(new UpdateItemUnitDtoValidator());
    }
}
