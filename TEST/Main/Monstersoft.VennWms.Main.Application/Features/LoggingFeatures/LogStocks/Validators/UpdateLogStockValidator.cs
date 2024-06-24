using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Validators;

public class UpdateLogStockValidator : AbstractValidator<UpdateLogStockCommand>
{
    public UpdateLogStockValidator()
    {
        RuleFor(x => x.LogStock).SetValidator(new UpdateLogStockDtoValidator());
    }
}
