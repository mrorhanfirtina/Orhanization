using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Validators;

public class DeleteUnitConversionValidator : AbstractValidator<DeleteUnitConversionCommand>
{
    public DeleteUnitConversionValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(1, int.MaxValue);
    }
}
