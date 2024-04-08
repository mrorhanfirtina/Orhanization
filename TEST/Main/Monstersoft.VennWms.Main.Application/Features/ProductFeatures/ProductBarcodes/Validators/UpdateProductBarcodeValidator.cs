using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateProductBarcodeValidator : AbstractValidator<UpdateProductBarcodeCommand>
{
    public UpdateProductBarcodeValidator()
    {
        RuleFor(x => x.ProductBarcode).SetValidator(new UpdateProductBarcodeDtoValidator());
    }
}
