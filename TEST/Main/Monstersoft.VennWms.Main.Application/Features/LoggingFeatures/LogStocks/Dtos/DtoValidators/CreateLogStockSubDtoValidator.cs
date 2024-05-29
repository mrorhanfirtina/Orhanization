using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.DtoValidators;

public class CreateLogStockSubDtoValidator : AbstractValidator<CreateLogStockSubDto>
{
    public CreateLogStockSubDtoValidator()
    {
        RuleFor(p => p.StockId)
            .Null()
            .NotEmpty().When(p => p.StockId != null)
            .NotEqual(Guid.Empty).When(p => p.StockId != null)
            .WithMessage("{PropertyName} alanı null olmalı veya boş Guid olmamalı veya eklenmelidir.");

        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromLocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToLocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.TransactionTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleForEach(x => x.LogStockAttributeValues).SetValidator(new CreateLogStockAttributeValueSubDtoValidator());
        RuleForEach(x => x.LogStockContainers).SetValidator(new CreateLogStockContainerSubDtoValidator());
        RuleForEach(x => x.LogStockReserveReasons).SetValidator(new CreateLogStockReserveReasonSubDtoValidator());
        RuleForEach(x => x.LogStockUnsuitReasons).SetValidator(new CreateLogStockUnsuitReasonSubDtoValidator());
    }
}


