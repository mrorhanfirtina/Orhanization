using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons.Dtos.DtoValidators;

public class CreateLogStockReserveReasonSubDtoValidator : AbstractValidator<CreateLogStockReserveReasonSubDto>
{
    public CreateLogStockReserveReasonSubDtoValidator()
    {
        RuleFor(p => p.FromReasonId).Null().NotEmpty().When(p => p.FromReasonId != null).NotEqual(Guid.Empty).When(p => p.FromReasonId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToReasonId).Null().NotEmpty().When(p => p.ToReasonId != null).NotEqual(Guid.Empty).When(p => p.ToReasonId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


