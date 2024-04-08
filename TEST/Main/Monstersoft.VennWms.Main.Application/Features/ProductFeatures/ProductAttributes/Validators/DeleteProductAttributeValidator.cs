using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Validators;

public class DeleteProductAttributeValidator : AbstractValidator<DeleteProductAttributeCommand>
{
    public DeleteProductAttributeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
