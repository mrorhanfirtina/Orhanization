using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Validators;

public class CreateStockValidator : AbstractValidator<CreateStockCommand>
{
    public CreateStockValidator()
    {
        RuleFor(x => x.Stock).SetValidator(new CreateStockDtoValidator());
    }
}
