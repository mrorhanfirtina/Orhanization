using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.BarcodeDtos;

public class UpdatePrinterSubDtoValidator : AbstractValidator<UpdatePrinterSubDto>
{
    public UpdatePrinterSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.PrinterAddress).NotEmpty().NotNull().MaximumLength(600);
    }
}


