using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LoggingDtos;

public class UpdateLogStockSubDtoValidator : AbstractValidator<UpdateLogStockSubDto>
{
    public UpdateLogStockSubDtoValidator()
    {
        RuleFor(p => p.StockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromLocaitonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToLocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.TransactionTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleForEach(x => x.LogStockAttributeValues).SetValidator(new UpdateLogStockAttributeValueSubDtoValidator());
        RuleForEach(x => x.LogStockContainers).SetValidator(new UpdateLogStockContainerSubDtoValidator());
        RuleForEach(x => x.LogStockReserveReasons).SetValidator(new UpdateLogStockReserveReasonSubDtoValidator());
        RuleForEach(x => x.LogStockUnsuitReasons).SetValidator(new UpdateLogStockUnsuitReasonSubDtoValidator());
    }
}


