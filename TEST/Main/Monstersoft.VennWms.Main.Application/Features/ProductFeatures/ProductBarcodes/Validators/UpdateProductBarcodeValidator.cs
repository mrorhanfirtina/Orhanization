using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateProductBarcodeValidator : AbstractValidator<UpdateProductBarcodeCommand>
{
    public UpdateProductBarcodeValidator()
    {
        RuleFor(x => x.ProductBarcode).SetValidator(new UpdateProductBarcodeDtoValidator());
    }
}
