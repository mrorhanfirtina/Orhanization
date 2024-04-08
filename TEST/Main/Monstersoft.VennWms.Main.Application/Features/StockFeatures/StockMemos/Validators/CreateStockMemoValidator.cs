using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Validators;

public class CreateStockMemoValidator : AbstractValidator<CreateStockMemoCommand>
{
    public CreateStockMemoValidator()
    {
        RuleFor(x => x.StockMemo).SetValidator(new CreateStockMemoDtoValidator());
    }
}
