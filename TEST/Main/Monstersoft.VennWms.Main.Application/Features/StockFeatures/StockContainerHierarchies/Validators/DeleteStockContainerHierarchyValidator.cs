using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Validators;

public class DeleteStockContainerHierarchyValidator : AbstractValidator<DeleteStockContainerHierarchyCommand>
{
    public DeleteStockContainerHierarchyValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
