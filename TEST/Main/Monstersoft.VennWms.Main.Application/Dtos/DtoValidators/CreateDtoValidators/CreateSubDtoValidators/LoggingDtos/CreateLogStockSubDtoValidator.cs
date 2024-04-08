using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LoggingDtos;

public class CreateLogStockSubDtoValidator : AbstractValidator<CreateLogStockSubDto>
{
    public CreateLogStockSubDtoValidator()
    {
        RuleFor(p => p.StockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromLocaitonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToLocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.TransactionTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleForEach(x => x.LogStockAttributeValues).SetValidator(new CreateLogStockAttributeValueSubDtoValidator());
        RuleForEach(x => x.LogStockContainers).SetValidator(new CreateLogStockContainerSubDtoValidator());
        RuleForEach(x => x.LogStockReserveReasons).SetValidator(new CreateLogStockReserveReasonSubDtoValidator());
        RuleForEach(x => x.LogStockUnsuitReasons).SetValidator(new CreateLogStockUnsuitReasonSubDtoValidator());
    }
}


