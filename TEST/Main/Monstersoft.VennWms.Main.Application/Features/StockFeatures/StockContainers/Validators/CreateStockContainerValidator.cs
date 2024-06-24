using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Validators;

public class CreateStockContainerValidator : AbstractValidator<CreateStockContainerCommand>
{
    public CreateStockContainerValidator()
    {
        RuleFor(x => x.StockContainer).SetValidator(new CreateStockContainerDtoValidator());
    }
}
