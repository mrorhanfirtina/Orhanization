using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.DtoValidators;

public class UpdateStockMemoDtoValidator : AbstractValidator<UpdateStockMemoDto>
{
    public UpdateStockMemoDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}



