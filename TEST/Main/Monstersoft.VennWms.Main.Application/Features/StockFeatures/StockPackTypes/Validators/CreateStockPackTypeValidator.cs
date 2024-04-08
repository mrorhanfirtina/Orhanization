using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Validators;

public class CreateStockPackTypeValidator : AbstractValidator<CreateStockPackTypeCommand>
{
    public CreateStockPackTypeValidator()
    {
        RuleFor(x => x.StockPackType).SetValidator(new CreateStockPackTypeDtoValidator());
    }
}
