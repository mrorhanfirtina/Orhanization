using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Validators;

public class UpdateStockUnsuitReasonValidator : AbstractValidator<UpdateStockUnsuitReasonCommand>
{
    public UpdateStockUnsuitReasonValidator()
    {
        RuleFor(x => x.StockUnsuitReason).SetValidator(new UpdateStockUnsuitReasonDtoValidator());
    }
}
