using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.DtoValidators;

public class UpdateStockUnsuitReasonSubDtoValidator : AbstractValidator<UpdateStockUnsuitReasonSubDto>
{
    public UpdateStockUnsuitReasonSubDtoValidator()
    {
        RuleFor(p => p.UnsuitReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


