using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Validators;

public class UpdateStockAttributeValidator : AbstractValidator<UpdateStockAttributeCommand>
{
    public UpdateStockAttributeValidator()
    {
        RuleFor(x => x.StockAttribute).SetValidator(new UpdateStockAttributeDtoValidator());
    }
}
