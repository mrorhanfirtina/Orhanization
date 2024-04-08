using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Validators;

public class UpdatePrinterValidator : AbstractValidator<UpdatePrinterCommand>
{
    public UpdatePrinterValidator()
    {
        RuleFor(x => x.Printer).SetValidator(new UpdatePrinterDtoValidator());
    }
}

