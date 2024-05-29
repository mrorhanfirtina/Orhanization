using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.DtoValidators;

public class CreateProductBarcodeDtoValidator : AbstractValidator<CreateProductBarcodeDto>
{
    public CreateProductBarcodeDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.BarcodeString).NotEmpty().NotNull().MaximumLength(140);
        RuleForEach(x => x.BarcodeSuppliers).SetValidator(new CreateBarcodeSupplierSubDtoValidator());
    }
}



