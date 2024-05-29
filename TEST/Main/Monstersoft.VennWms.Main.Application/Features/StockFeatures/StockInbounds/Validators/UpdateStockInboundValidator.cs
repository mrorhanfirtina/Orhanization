using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Validators;

public class UpdateStockInboundValidator : AbstractValidator<UpdateStockInboundCommand>
{
    public UpdateStockInboundValidator()
    {
        RuleFor(x => x.StockInbound).SetValidator(new UpdateStockInboundDtoValidator());
    }
}
