using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateProductBarcodeValidator : AbstractValidator<CreateProductBarcodeCommand>
{
    public CreateProductBarcodeValidator()
    {
        RuleFor(x => x.ProductBarcode).SetValidator(new CreateProductBarcodeDtoValidator());
    }
}
