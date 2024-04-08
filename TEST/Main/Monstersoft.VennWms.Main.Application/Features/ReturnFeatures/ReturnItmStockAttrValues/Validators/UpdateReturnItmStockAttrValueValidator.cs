using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Validators;

public class UpdateReturnItmStockAttrValueValidator : AbstractValidator<UpdateReturnItmStockAttrValueCommand>
{
    public UpdateReturnItmStockAttrValueValidator()
    {
        RuleFor(x => x.ReturnItmStockAttrValue).SetValidator(new UpdateReturnItmStockAttrValueDtoValidator());
    }
}
