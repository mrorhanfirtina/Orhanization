using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Validators;

public class CreateStockValidator : AbstractValidator<CreateStockCommand>
{
    public CreateStockValidator()
    {
        RuleFor(x => x.Stock).SetValidator(new CreateStockDtoValidator());
    }
}
