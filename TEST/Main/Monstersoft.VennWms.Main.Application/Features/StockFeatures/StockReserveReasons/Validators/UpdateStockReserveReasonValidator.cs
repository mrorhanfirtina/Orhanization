using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Validators;

public class UpdateStockReserveReasonValidator : AbstractValidator<UpdateStockReserveReasonCommand>
{
    public UpdateStockReserveReasonValidator()
    {
        RuleFor(x => x.StockReserveReason).SetValidator(new UpdateStockReserveReasonDtoValidator());
    }
}
