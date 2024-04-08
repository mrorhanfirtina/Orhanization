using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Validators;

public class UpdateStockReserveReasonValidator : AbstractValidator<UpdateStockReserveReasonCommand>
{
    public UpdateStockReserveReasonValidator()
    {
        RuleFor(x => x.StockReserveReason).SetValidator(new UpdateStockReserveReasonDtoValidator());
    }
}
