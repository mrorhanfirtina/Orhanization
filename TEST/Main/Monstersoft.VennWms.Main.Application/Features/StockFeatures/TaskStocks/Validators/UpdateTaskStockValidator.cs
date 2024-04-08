using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Validators;

public class UpdateTaskStockValidator : AbstractValidator<UpdateTaskStockCommand>
{
    public UpdateTaskStockValidator()
    {
        RuleFor(x => x.TaskStock).SetValidator(new UpdateTaskStockDtoValidator());
    }
}
