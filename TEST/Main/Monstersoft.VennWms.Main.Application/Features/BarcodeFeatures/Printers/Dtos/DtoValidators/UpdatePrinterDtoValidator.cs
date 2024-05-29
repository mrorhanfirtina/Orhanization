using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.DtoValidators;

public class UpdatePrinterDtoValidator : AbstractValidator<UpdatePrinterDto>
{
    public UpdatePrinterDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.PrinterAddress).NotEmpty().NotNull().MaximumLength(600);
    }
}



