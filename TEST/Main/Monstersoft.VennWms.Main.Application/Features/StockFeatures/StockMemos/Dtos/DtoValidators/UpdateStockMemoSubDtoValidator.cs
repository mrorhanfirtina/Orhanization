using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.DtoValidators;

public class UpdateStockMemoSubDtoValidator : AbstractValidator<UpdateStockMemoSubDto>
{
    public UpdateStockMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


