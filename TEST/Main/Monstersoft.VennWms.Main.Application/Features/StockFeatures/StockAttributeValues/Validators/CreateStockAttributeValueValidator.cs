using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Validators;

public class CreateStockAttributeValueValidator : AbstractValidator<CreateStockAttributeValueCommand>
{
    public CreateStockAttributeValueValidator()
    {
        RuleFor(x => x.StockAttributeValue).SetValidator(new CreateStockAttributeValueDtoValidator());
    }
}
