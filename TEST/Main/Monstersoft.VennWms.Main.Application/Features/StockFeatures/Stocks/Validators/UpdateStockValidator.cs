using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Validators;

public class UpdateStockValidator : AbstractValidator<UpdateStockCommand>
{
    public UpdateStockValidator()
    {
        RuleFor(x => x.Stock).SetValidator(new UpdateStockDtoValidator());
    }
}
