using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Validators;

public class UpdateBarcodeValidator : AbstractValidator<UpdateBarcodeCommand>
{
    public UpdateBarcodeValidator()
    {
        RuleFor(x => x.Barcode).SetValidator(new UpdateBarcodeDtoValidator());
    }
}

