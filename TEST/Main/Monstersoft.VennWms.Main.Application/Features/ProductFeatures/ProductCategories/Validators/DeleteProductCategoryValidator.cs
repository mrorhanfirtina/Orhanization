using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Validators;

public class DeleteProductCategoryValidator : AbstractValidator<DeleteProductCategoryCommand>
{
    public DeleteProductCategoryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

