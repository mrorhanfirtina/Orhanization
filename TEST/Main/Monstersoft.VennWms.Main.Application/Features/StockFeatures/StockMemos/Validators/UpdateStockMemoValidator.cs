using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Validators;

public class UpdateStockMemoValidator : AbstractValidator<UpdateStockMemoCommand>
{
    public UpdateStockMemoValidator()
    {
        RuleFor(x => x.StockMemo).SetValidator(new UpdateStockMemoDtoValidator());
    }
}
