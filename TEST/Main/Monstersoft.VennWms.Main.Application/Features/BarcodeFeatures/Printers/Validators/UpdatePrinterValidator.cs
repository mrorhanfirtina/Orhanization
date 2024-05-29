using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Validators;

public class UpdatePrinterValidator : AbstractValidator<UpdatePrinterCommand>
{
    public UpdatePrinterValidator()
    {
        RuleFor(x => x.Printer).SetValidator(new UpdatePrinterDtoValidator());
    }
}

