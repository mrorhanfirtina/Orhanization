using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update.UpdateDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update.Validators;

public class UpdateBarcodeBarcodeAreaDtoValidator : AbstractValidator<UpdateBarcodeBarcodeAreaDto>
{
    public UpdateBarcodeBarcodeAreaDtoValidator()
    {
        RuleFor(p => p.TextField).NotNull().NotEmpty().MinimumLength(5);
        RuleFor(p => p.QueryField).NotNull().NotEmpty().MinimumLength(5);
    }
}
