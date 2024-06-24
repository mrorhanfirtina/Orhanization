using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Validators;

public class UpdateStockUnsuitReasonValidator : AbstractValidator<UpdateStockUnsuitReasonCommand>
{
    public UpdateStockUnsuitReasonValidator()
    {
        RuleFor(x => x.StockUnsuitReason).SetValidator(new UpdateStockUnsuitReasonDtoValidator());
    }
}
