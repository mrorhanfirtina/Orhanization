using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;

public class UpdateStockDtoValidator : AbstractValidator<UpdateStockDto>
{
    public UpdateStockDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.FreeQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.UnitId).NotEmpty().InclusiveBetween(0, int.MaxValue).WithMessage("{PropertyName} alanı boş olamaz.");
        RuleFor(p => p.ReceiptId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.StockContainer).SetValidator(new UpdateStockContainerSubDtoValidator());
        RuleForEach(x => x.StockAttributeValues).SetValidator(new UpdateStockAttributeValueSubDtoValidator());
        RuleForEach(x => x.StockMemos).SetValidator(new UpdateStockMemoSubDtoValidator());
        RuleForEach(x => x.StockReserveReasons).SetValidator(new UpdateStockReserveReasonSubDtoValidator());
        RuleForEach(x => x.StockUnsuitReasons).SetValidator(new UpdateStockUnsuitReasonSubDtoValidator());
    }
}



