using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Validators;

public class DeleteProductCategoryListValidator : AbstractValidator<DeleteProductCategoryListCommand>
{
    public DeleteProductCategoryListValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(1, int.MaxValue);
    }
}


