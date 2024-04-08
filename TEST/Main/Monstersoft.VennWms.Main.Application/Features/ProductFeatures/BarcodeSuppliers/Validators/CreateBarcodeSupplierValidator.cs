using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateBarcodeSupplierValidator : AbstractValidator<CreateBarcodeSupplierCommand>
{
    public CreateBarcodeSupplierValidator()
    {
        RuleFor(x => x.BarcodeSupplier).SetValidator(new CreateBarcodeSupplierDtoValidator());
    }
}
