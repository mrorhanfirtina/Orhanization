using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Validators;

public class UpdateStockContainerValidator : AbstractValidator<UpdateStockContainerCommand>
{
    public UpdateStockContainerValidator()
    {
        RuleFor(x => x.StockContainer).SetValidator(new UpdateStockContainerDtoValidator());
    }
}
