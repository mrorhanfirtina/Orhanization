using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.DtoValidators;

public class CreateStockReserveReasonDtoValidator : AbstractValidator<CreateStockReserveReasonDto>
{
    public CreateStockReserveReasonDtoValidator()
    {
        RuleFor(p => p.StockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReserveReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}



