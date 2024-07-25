using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Validators;

public class GetByIdStockContainerHierarchyQueryValidator : AbstractValidator<GetByIdStockContainerHierarchyQuery>
{
    public GetByIdStockContainerHierarchyQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
