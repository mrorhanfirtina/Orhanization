using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.BarcodeDtos;

public class CreatePrinterSubDtoValidator : AbstractValidator<CreatePrinterSubDto>
{
    public CreatePrinterSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.PrinterAddress).NotEmpty().NotNull().MaximumLength(600);

    }
}


