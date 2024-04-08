using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Validators;

public class CreateReturnItmStockAttrValueValidator : AbstractValidator<CreateReturnItmStockAttrValueCommand>
{
    public CreateReturnItmStockAttrValueValidator()
    {
        RuleFor(x => x.ReturnItmStockAttrValue).SetValidator(new CreateReturnItmStockAttrValueDtoValidator());
    }
}
