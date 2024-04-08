using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;

public class CreateStockDtoValidator : AbstractValidator<CreateStockDto>
{
    public CreateStockDtoValidator()
    {
        RuleFor(p => p.StockContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.FreeQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.UnitId).NotEmpty().ExclusiveBetween(0, int.MaxValue).WithMessage("{PropertyName} alanı boş olamaz.");
        RuleFor(p => p.ReceiptId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.StockContainer).SetValidator(new CreateStockContainerSubDtoValidator());
        RuleForEach(x => x.StockAttributeValues).SetValidator(new CreateStockAttributeValueSubDtoValidator());
        RuleForEach(x => x.StockMemos).SetValidator(new CreateStockMemoSubDtoValidator());
        RuleForEach(x => x.StockReserveReasons).SetValidator(new CreateStockReserveReasonSubDtoValidator());
        RuleForEach(x => x.StockUnsuitReasons).SetValidator(new CreateStockUnsuitReasonSubDtoValidator());
    }
}



