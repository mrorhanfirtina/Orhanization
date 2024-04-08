using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Validators;

public class CreateBarcodePrinterValidator : AbstractValidator<CreateBarcodePrinterCommand>
{
    public CreateBarcodePrinterValidator()
    {
        RuleFor(x => x.BarcodePrinter).SetValidator(new CreateBarcodePrinterDtoValidator());
    }
}
