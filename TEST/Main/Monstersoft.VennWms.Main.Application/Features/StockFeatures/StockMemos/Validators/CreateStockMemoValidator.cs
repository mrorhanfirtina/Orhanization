using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Validators;

public class CreateStockMemoValidator : AbstractValidator<CreateStockMemoCommand>
{
    public CreateStockMemoValidator()
    {
        RuleFor(x => x.StockMemo).SetValidator(new CreateStockMemoDtoValidator());
    }
}
