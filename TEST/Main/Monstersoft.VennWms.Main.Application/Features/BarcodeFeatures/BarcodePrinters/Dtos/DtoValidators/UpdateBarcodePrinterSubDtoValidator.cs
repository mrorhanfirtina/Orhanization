using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.DtoValidators;

public class UpdateBarcodePrinterSubDtoValidator : AbstractValidator<UpdateBarcodePrinterSubDto>
{
    public UpdateBarcodePrinterSubDtoValidator()
    {
        RuleFor(p => p.PrinterId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
