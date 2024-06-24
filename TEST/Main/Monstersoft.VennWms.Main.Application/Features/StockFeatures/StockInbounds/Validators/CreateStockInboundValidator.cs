using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Validators;

public class CreateStockInboundValidator : AbstractValidator<CreateStockInboundCommand>
{
    public CreateStockInboundValidator()
    {
        RuleFor(x => x.StockInbound).SetValidator(new CreateStockInboundDtoValidator());
    }
}
