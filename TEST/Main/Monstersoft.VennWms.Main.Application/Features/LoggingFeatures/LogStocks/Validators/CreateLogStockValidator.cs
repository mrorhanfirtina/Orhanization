using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Validators;

public class CreateLogStockValidator : AbstractValidator<CreateLogStockCommand>
{
    public CreateLogStockValidator()
    {
        RuleFor(x => x.LogStock).SetValidator(new CreateLogStockDtoValidator());
    }
}
