using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateItemUnitValidator : AbstractValidator<UpdateItemUnitCommand>
{
    public UpdateItemUnitValidator()
    {
        RuleFor(x => x.ItemUnit).SetValidator(new UpdateItemUnitDtoValidator());
    }
}
