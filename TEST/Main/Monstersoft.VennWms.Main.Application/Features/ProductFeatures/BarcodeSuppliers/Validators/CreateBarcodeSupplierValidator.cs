using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateBarcodeSupplierValidator : AbstractValidator<CreateBarcodeSupplierCommand>
{
    public CreateBarcodeSupplierValidator()
    {
        RuleFor(x => x.BarcodeSupplier).SetValidator(new CreateBarcodeSupplierDtoValidator());
    }
}
