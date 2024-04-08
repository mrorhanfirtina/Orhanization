using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LoggingDtos;

public class UpdateLogStockUnsuitReasonSubDtoValidator : AbstractValidator<UpdateLogStockUnsuitReasonSubDto>
{
    public UpdateLogStockUnsuitReasonSubDtoValidator()
    {
        RuleFor(p => p.FromReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


