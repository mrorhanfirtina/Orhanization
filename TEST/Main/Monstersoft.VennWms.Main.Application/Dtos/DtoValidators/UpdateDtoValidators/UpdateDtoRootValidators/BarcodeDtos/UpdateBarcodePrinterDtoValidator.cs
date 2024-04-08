using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.BarcodeDtos;

public class UpdateBarcodePrinterDtoValidator : AbstractValidator<UpdateBarcodePrinterDto>
{
    public UpdateBarcodePrinterDtoValidator()
    {
        RuleFor(p => p.BarcodeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.PrinterId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
