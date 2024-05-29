using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.DtoValidators;

public class CreateLogStockUnsuitReasonDtoValidator : AbstractValidator<CreateLogStockUnsuitReasonDto>
{
    public CreateLogStockUnsuitReasonDtoValidator()
    {
        RuleFor(p => p.LogStockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromReasonId).Null().NotEmpty().When(p => p.FromReasonId != null).NotEqual(Guid.Empty).When(p => p.FromReasonId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToReasonId).Null().NotEmpty().When(p => p.ToReasonId != null).NotEqual(Guid.Empty).When(p => p.ToReasonId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}



