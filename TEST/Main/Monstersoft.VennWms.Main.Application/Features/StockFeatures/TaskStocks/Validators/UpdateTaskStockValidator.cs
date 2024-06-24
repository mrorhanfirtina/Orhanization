using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Validators;

public class UpdateTaskStockValidator : AbstractValidator<UpdateTaskStockCommand>
{
    public UpdateTaskStockValidator()
    {
        RuleFor(x => x.TaskStock).SetValidator(new UpdateTaskStockDtoValidator());
    }
}
