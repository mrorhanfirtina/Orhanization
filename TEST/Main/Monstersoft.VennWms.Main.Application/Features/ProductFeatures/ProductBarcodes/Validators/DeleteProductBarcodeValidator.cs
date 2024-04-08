using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features;

public class DeleteProductBarcodeValidator : AbstractValidator<DeleteProductBarcodeCommand>
{
    public DeleteProductBarcodeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
