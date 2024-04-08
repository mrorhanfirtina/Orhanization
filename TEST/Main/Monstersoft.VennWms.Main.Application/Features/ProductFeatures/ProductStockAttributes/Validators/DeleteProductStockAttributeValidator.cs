using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Delete;





namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Validators;

public class DeleteProductStockAttributeValidator : AbstractValidator<DeleteProductStockAttributeCommand>
{
    public DeleteProductStockAttributeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

