using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Validators;

public class CreateBarcodeValidator : AbstractValidator<CreateBarcodeCommand>
{
    public CreateBarcodeValidator()
    {
        RuleFor(x => x.Barcode).SetValidator(new CreateBarcodeDtoValidator());
    }
}

