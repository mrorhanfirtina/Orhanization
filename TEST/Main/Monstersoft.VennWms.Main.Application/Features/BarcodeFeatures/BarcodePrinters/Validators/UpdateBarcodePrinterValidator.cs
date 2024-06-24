using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Validators;

public class UpdateBarcodePrinterValidator : AbstractValidator<UpdateBarcodePrinterCommand>
{
    public UpdateBarcodePrinterValidator()
    {
        RuleFor(x => x.BarcodePrinter).SetValidator(new UpdateBarcodePrinterDtoValidator());
    }
}
