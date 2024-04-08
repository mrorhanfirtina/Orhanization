using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LoggingDtos;

public class UpdateLogStockReserveReasonSubDtoValidator : AbstractValidator<UpdateLogStockReserveReasonSubDto>
{
    public UpdateLogStockReserveReasonSubDtoValidator()
    {
        RuleFor(p => p.FromReasaonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToReasaonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


