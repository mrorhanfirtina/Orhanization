using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.DtoValidators;

public class UpdatePrinterSubDtoValidator : AbstractValidator<UpdatePrinterSubDto>
{
    public UpdatePrinterSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.PrinterAddress).NotEmpty().NotNull().MaximumLength(600);
    }
}


