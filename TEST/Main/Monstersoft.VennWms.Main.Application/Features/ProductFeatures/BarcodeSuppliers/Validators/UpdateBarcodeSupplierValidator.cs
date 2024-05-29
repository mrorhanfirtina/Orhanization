using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateBarcodeSupplierValidator : AbstractValidator<UpdateBarcodeSupplierCommand>
{
    public UpdateBarcodeSupplierValidator()
    {
        RuleFor(x => x.BarcodeSupplier).SetValidator(new UpdateBarcodeSupplierDtoValidator());
    }
}
