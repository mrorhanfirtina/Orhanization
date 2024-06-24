using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Validators;

public class CreateBarcodeValidator : AbstractValidator<CreateBarcodeCommand>
{
    public CreateBarcodeValidator()
    {
        RuleFor(x => x.Barcode).SetValidator(new CreateBarcodeDtoValidator());
    }
}

