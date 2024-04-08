using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ProductDtos;

public class CreateProductBarcodeSubDtoValidator : AbstractValidator<CreateProductBarcodeSubDto>
{
    public CreateProductBarcodeSubDtoValidator()
    {
        RuleFor(p => p.BarcodeString).NotEmpty().NotNull().MaximumLength(140);
        RuleForEach(x => x.BarcodeSuppliers).SetValidator(new CreateBarcodeSupplierSubDtoValidator());
    }
}


