using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update.UpdateDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update.Validators;

public class UpdateBarcodePrinterDtoValidator : AbstractValidator<UpdateBarcodePrinterDto>
{
    public UpdateBarcodePrinterDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MinimumLength(3);
        RuleFor(p => p.PrinterAddress).NotEmpty().NotNull().MinimumLength(10);
    }
}
