using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Validators;

public class CreateStockAttributeValidator : AbstractValidator<CreateStockAttributeCommand>
{
    public CreateStockAttributeValidator()
    {
        RuleFor(x => x.StockAttribute).SetValidator(new CreateStockAttributeDtoValidator());
    }
}
