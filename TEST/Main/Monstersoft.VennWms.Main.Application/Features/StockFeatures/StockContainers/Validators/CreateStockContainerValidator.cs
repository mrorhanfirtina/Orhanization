using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Validators;

public class CreateStockContainerValidator : AbstractValidator<CreateStockContainerCommand>
{
    public CreateStockContainerValidator()
    {
        RuleFor(x => x.StockContainer).SetValidator(new CreateStockContainerDtoValidator());
    }
}
