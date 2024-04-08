using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.BarcodeDtos;

public class UpdateBarcodePrinterSubDtoValidator : AbstractValidator<UpdateBarcodePrinterSubDto>
{
    public UpdateBarcodePrinterSubDtoValidator()
    {
        RuleFor(p => p.PrinterId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
