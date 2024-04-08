using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Validators;

public class UpdateStockPackTypeValidator : AbstractValidator<UpdateStockPackTypeCommand>
{
    public UpdateStockPackTypeValidator()
    {
        RuleFor(x => x.StockPackType).SetValidator(new UpdateStockPackTypeDtoValidator());
    }
}
