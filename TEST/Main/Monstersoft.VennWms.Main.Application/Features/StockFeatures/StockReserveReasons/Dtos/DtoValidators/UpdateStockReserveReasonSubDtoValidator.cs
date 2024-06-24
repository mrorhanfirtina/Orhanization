using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.DtoValidators;

public class UpdateStockReserveReasonSubDtoValidator : AbstractValidator<UpdateStockReserveReasonSubDto>
{
    public UpdateStockReserveReasonSubDtoValidator()
    {
        RuleFor(p => p.ReserveReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


