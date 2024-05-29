using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.DtoValidators;

public class CreateBarcodePrinterDtoValidator : AbstractValidator<CreateBarcodePrinterDto>
{
    public CreateBarcodePrinterDtoValidator()
    {
        RuleFor(p => p.BarcodeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.PrinterId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
