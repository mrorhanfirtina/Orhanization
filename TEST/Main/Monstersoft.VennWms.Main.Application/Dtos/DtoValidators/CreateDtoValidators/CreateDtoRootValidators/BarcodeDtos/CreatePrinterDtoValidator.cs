using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.BarcodeDtos;

public class CreatePrinterDtoValidator : AbstractValidator<CreatePrinterDto>
{
    public CreatePrinterDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.PrinterAddress).NotEmpty().NotNull().MaximumLength(600);
    }
}



