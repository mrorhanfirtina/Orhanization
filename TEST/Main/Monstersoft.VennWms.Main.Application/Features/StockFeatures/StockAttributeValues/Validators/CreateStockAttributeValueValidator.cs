using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Validators;

public class CreateStockAttributeValueValidator : AbstractValidator<CreateStockAttributeValueCommand>
{
    public CreateStockAttributeValueValidator()
    {
        RuleFor(x => x.StockAttributeValue).SetValidator(new CreateStockAttributeValueDtoValidator());
    }
}
