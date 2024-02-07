using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update.Validators;

public class UpdateBarcodeCommandValidator : AbstractValidator<UpdateBarcodeCommand>
{
    public UpdateBarcodeCommandValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MinimumLength(3);
        RuleFor(p => p.Copy).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Query).NotEmpty().NotNull().MinimumLength(15);
        RuleFor(p => p.Text).NotEmpty().NotNull().MinimumLength(10);

        RuleForEach(x => x.Printers).SetValidator(new UpdateBarcodePrinterDtoValidator());
        RuleForEach(x => x.BarcodeAreas).SetValidator(new UpdateBarcodeBarcodeAreaDtoValidator());
    }
}
