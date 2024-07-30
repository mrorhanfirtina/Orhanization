using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Validators;

public class DeleteActionParameterValidator : AbstractValidator<DeleteActionParameterCommand>
{
    public DeleteActionParameterValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
