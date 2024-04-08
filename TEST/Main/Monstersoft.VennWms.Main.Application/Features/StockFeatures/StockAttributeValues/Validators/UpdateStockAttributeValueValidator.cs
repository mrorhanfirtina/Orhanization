using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Validators;

public class UpdateStockAttributeValueValidator : AbstractValidator<UpdateStockAttributeValueCommand>
{
    public UpdateStockAttributeValueValidator()
    {
        RuleFor(x => x.StockAttributeValue).SetValidator(new UpdateStockAttributeValueDtoValidator());
    }
}
