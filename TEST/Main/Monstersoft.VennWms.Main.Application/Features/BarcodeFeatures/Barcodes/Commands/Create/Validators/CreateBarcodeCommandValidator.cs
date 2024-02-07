using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create.Validators;

public class CreateBarcodeCommandValidator : AbstractValidator<CreateBarcodeCommand>
{
    public CreateBarcodeCommandValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MinimumLength(3);
        RuleFor(p => p.Copy).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Query).NotEmpty().NotNull().MinimumLength(15);
        RuleFor(p => p.Text).NotEmpty().NotNull().MinimumLength(10);

        RuleForEach(x => x.Printers).SetValidator(new CreateBarcodePrinterDtoValidator());
        RuleForEach(x => x.BarcodeAreas).SetValidator(new CreateBarcodeBarcodeAreaDtoValidator());
    }
}

