using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateProductBarcodeValidator : AbstractValidator<CreateProductBarcodeCommand>
{
    public CreateProductBarcodeValidator()
    {
        RuleFor(x => x.ProductBarcode).SetValidator(new CreateProductBarcodeDtoValidator());
    }
}
