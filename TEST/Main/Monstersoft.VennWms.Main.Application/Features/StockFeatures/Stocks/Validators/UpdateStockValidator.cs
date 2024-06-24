using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Validators;

public class UpdateStockValidator : AbstractValidator<UpdateStockCommand>
{
    public UpdateStockValidator()
    {
        RuleFor(x => x.Stock).SetValidator(new UpdateStockDtoValidator());
    }
}
