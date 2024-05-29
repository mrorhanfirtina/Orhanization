using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.DtoValidators;

public class CreatePrinterSubDtoValidator : AbstractValidator<CreatePrinterSubDto>
{
    public CreatePrinterSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.PrinterAddress).NotEmpty().NotNull().MaximumLength(600);

    }
}


