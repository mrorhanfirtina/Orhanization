using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.DtoValidators;

public class CreateStockReserveReasonSubDtoValidator : AbstractValidator<CreateStockReserveReasonSubDto>
{
    public CreateStockReserveReasonSubDtoValidator()
    {
        RuleFor(p => p.ReserveReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


