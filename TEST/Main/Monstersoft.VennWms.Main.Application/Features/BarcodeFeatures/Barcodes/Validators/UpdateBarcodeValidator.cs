using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Validators;

public class UpdateBarcodeValidator : AbstractValidator<UpdateBarcodeCommand>
{
    public UpdateBarcodeValidator()
    {
        RuleFor(x => x.Barcode).SetValidator(new UpdateBarcodeDtoValidator());
    }
}

