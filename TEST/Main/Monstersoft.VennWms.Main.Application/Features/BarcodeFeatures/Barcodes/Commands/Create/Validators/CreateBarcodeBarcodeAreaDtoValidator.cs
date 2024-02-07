using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create.CreateDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create.Validators;

public class CreateBarcodeBarcodeAreaDtoValidator : AbstractValidator<CreateBarcodeBarcodeAreaDto>
{
    public CreateBarcodeBarcodeAreaDtoValidator()
    {
        RuleFor(p => p.TextField).NotNull().NotEmpty().MinimumLength(5);
        RuleFor(p => p.QueryField).NotNull().NotEmpty().MinimumLength(5);
    }
}
