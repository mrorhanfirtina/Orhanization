using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LoggingDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Validators;

public class UpdateLogStockValidator : AbstractValidator<UpdateLogStockCommand>
{
    public UpdateLogStockValidator()
    {
        RuleFor(x => x.LogStock).SetValidator(new UpdateLogStockDtoValidator());
    }
}
