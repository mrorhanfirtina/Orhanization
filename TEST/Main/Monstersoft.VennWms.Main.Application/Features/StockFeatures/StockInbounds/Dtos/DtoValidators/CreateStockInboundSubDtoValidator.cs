using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.DtoValidators;

public class CreateStockInboundSubDtoValidator : AbstractValidator<CreateStockInboundSubDto>
{
    public CreateStockInboundSubDtoValidator()
    {
        RuleFor(p => p.ReceiptId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.CuQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.CuQuantityFree).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.CuItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
