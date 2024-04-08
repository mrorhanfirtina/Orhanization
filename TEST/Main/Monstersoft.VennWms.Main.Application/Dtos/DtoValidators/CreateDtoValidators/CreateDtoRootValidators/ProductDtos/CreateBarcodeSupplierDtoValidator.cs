using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;

public class CreateBarcodeSupplierDtoValidator : AbstractValidator<CreateBarcodeSupplierDto>
{
    public CreateBarcodeSupplierDtoValidator()
    {
        RuleFor(p => p.ProductBarcodeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.SupplierId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}



