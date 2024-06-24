using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.DtoValidators;

public class UpdateStockDtoValidator : AbstractValidator<UpdateStockDto>
{
    public UpdateStockDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.CuQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.CuQuantityFree).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.CuItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.StockAttributeValues).SetValidator(new UpdateStockAttributeValueSubDtoValidator());
        RuleForEach(x => x.StockMemos).SetValidator(new UpdateStockMemoSubDtoValidator());
        RuleForEach(x => x.StockReserveReasons).SetValidator(new UpdateStockReserveReasonSubDtoValidator());
        RuleForEach(x => x.StockUnsuitReasons).SetValidator(new UpdateStockUnsuitReasonSubDtoValidator());
        RuleForEach(x => x.StockInbounds).SetValidator(new UpdateStockInboundSubDtoValidator());
        RuleForEach(x => x.StockPackTypes).SetValidator(new UpdateStockPackTypeSubDtoValidator());
    }
}



