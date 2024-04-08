using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateBarcodeSupplierValidator : AbstractValidator<UpdateBarcodeSupplierCommand>
{
    public UpdateBarcodeSupplierValidator()
    {
        RuleFor(x => x.BarcodeSupplier).SetValidator(new UpdateBarcodeSupplierDtoValidator());
    }
}
