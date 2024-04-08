using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Validators;

public class CreateTaskStockValidator : AbstractValidator<CreateTaskStockCommand>
{
    public CreateTaskStockValidator()
    {
        RuleFor(x => x.TaskStock).SetValidator(new CreateTaskStockDtoValidator());
    }
}
