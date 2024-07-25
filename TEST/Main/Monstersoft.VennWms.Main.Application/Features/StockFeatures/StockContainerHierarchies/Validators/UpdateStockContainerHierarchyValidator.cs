using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Validators;

public class UpdateStockContainerHierarchyValidator : AbstractValidator<UpdateStockContainerHierarchyCommand>
{
    public UpdateStockContainerHierarchyValidator()
    {
        RuleFor(x => x.StockContainerHierarchy).SetValidator(new UpdateStockContainerHierarchyDtoValidator());
    }
}
