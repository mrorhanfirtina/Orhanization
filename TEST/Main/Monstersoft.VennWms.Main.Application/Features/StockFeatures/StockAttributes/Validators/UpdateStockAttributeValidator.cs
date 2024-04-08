using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Validators;

public class UpdateStockAttributeValidator : AbstractValidator<UpdateStockAttributeCommand>
{
    public UpdateStockAttributeValidator()
    {
        RuleFor(x => x.StockAttribute).SetValidator(new UpdateStockAttributeDtoValidator());
    }
}
