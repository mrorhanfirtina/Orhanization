using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Validators;

public class CreateBarcodePrinterValidator : AbstractValidator<CreateBarcodePrinterCommand>
{
    public CreateBarcodePrinterValidator()
    {
        RuleFor(x => x.BarcodePrinter).SetValidator(new CreateBarcodePrinterDtoValidator());
    }
}
