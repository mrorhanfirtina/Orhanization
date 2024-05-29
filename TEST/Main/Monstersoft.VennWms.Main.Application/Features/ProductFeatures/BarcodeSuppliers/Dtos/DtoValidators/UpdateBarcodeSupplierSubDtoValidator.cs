using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.DtoValidators;

public class UpdateBarcodeSupplierSubDtoValidator : AbstractValidator<UpdateBarcodeSupplierSubDto>
{
    public UpdateBarcodeSupplierSubDtoValidator()
    {
        RuleFor(p => p.SupplierId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


