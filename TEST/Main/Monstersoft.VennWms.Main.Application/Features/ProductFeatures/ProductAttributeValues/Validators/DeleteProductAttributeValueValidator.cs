using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Validators;

public class DeleteProductAttributeValueValidator : AbstractValidator<DeleteProductAttributeValueCommand>
{
    public DeleteProductAttributeValueValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
