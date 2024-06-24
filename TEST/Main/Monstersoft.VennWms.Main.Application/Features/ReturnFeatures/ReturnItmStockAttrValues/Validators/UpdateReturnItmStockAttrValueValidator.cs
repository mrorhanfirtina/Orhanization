using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Validators;

public class UpdateReturnItmStockAttrValueValidator : AbstractValidator<UpdateReturnItmStockAttrValueCommand>
{
    public UpdateReturnItmStockAttrValueValidator()
    {
        RuleFor(x => x.ReturnItmStockAttrValue).SetValidator(new UpdateReturnItmStockAttrValueDtoValidator());
    }
}
