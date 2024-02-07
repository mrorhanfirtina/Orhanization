using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete.Validators;

public class DeleteBarcodeCommandValidator : AbstractValidator<DeleteBarcodeCommand>
{
    public DeleteBarcodeCommandValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MinimumLength(3);
        RuleFor(p => p.DepositorCode).NotEmpty().NotNull().MinimumLength(2);
    }
}
