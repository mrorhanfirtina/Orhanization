using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Validators;

public class DeleteProductValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
