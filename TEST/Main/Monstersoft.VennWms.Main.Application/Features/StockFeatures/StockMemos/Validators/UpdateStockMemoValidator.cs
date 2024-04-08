using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Validators;

public class UpdateStockMemoValidator : AbstractValidator<UpdateStockMemoCommand>
{
    public UpdateStockMemoValidator()
    {
        RuleFor(x => x.StockMemo).SetValidator(new UpdateStockMemoDtoValidator());
    }
}
