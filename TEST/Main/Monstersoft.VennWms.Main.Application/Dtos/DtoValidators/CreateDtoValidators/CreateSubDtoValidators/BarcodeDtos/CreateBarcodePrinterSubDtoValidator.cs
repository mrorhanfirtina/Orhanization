using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.BarcodeDtos;

public class CreateBarcodePrinterSubDtoValidator : AbstractValidator<CreateBarcodePrinterSubDto>
{
    public CreateBarcodePrinterSubDtoValidator()
    {
        RuleFor(p => p.PrinterId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
