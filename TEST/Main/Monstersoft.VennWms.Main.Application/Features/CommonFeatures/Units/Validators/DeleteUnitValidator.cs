using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Validators;

public class DeleteUnitValidator : AbstractValidator<DeleteUnitCommand>
{
    public DeleteUnitValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
