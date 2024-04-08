using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Validators;

public class UpdateBarcodePrinterValidator : AbstractValidator<UpdateBarcodePrinterCommand>
{
    public UpdateBarcodePrinterValidator()
    {
        RuleFor(x => x.BarcodePrinter).SetValidator(new UpdateBarcodePrinterDtoValidator());
    }
}
