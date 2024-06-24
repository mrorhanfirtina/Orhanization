using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Validators;

public class CreateStockReserveReasonValidator : AbstractValidator<CreateStockReserveReasonCommand>
{
    public CreateStockReserveReasonValidator()
    {
        RuleFor(x => x.StockReserveReason).SetValidator(new CreateStockReserveReasonDtoValidator());
    }
}
