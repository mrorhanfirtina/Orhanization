using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.DtoValidators;

public class UpdateLogStockUnsuitReasonSubDtoValidator : AbstractValidator<UpdateLogStockUnsuitReasonSubDto>
{
    public UpdateLogStockUnsuitReasonSubDtoValidator()
    {
        RuleFor(p => p.FromReasonId).Null().NotEmpty().When(p => p.FromReasonId != null).NotEqual(Guid.Empty).When(p => p.FromReasonId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToReasonId).Null().NotEmpty().When(p => p.ToReasonId != null).NotEqual(Guid.Empty).When(p => p.ToReasonId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


