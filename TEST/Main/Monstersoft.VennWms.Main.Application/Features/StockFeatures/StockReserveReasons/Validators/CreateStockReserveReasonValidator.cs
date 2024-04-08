using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Validators;

public class CreateStockReserveReasonValidator : AbstractValidator<CreateStockReserveReasonCommand>
{
    public CreateStockReserveReasonValidator()
    {
        RuleFor(x => x.StockReserveReason).SetValidator(new CreateStockReserveReasonDtoValidator());
    }
}
