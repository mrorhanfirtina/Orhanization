using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Validators;

public class CreatePrinterValidator : AbstractValidator<CreatePrinterCommand>
{
    public CreatePrinterValidator()
    {
        RuleFor(x => x.Printer).SetValidator(new CreatePrinterDtoValidator());
    }
}

