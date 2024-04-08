using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Validators;

public class CreateStockUnsuitReasonValidator : AbstractValidator<CreateStockUnsuitReasonCommand>
{
    public CreateStockUnsuitReasonValidator()
    {
        RuleFor(x => x.StockUnsuitReason).SetValidator(new CreateStockUnsuitReasonDtoValidator());
    }
}
