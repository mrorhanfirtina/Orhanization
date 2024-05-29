using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Validators;

public class UpdateStockPackTypeValidator : AbstractValidator<UpdateStockPackTypeCommand>
{
    public UpdateStockPackTypeValidator()
    {
        RuleFor(x => x.StockPackType).SetValidator(new UpdateStockPackTypeDtoValidator());
    }
}
