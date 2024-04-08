using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features;

public class DeleteBarcodeSupplierValidator : AbstractValidator<DeleteBarcodeSupplierCommand>
{
    public DeleteBarcodeSupplierValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
