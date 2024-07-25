using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Validators;

public class CreateStockContainerHierarchyValidator : AbstractValidator<CreateStockContainerHierarchyCommand>
{
    public CreateStockContainerHierarchyValidator()
    {
        RuleFor(x => x.StockContainerHierarchy).SetValidator(new CreateStockContainerHierarchyDtoValidator());
    }
}
