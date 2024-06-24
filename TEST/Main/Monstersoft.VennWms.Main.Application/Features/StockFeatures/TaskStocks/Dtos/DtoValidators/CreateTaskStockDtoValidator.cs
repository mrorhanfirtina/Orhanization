using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.DtoValidators;

public class CreateTaskStockDtoValidator : AbstractValidator<CreateTaskStockDto>
{
    public CreateTaskStockDtoValidator()
    {
        RuleFor(p => p.WorkTaskId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
    }
}



