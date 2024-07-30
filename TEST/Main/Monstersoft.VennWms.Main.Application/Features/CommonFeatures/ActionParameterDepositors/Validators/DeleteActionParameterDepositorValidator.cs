using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Validators;

public class DeleteActionParameterDepositorValidator : AbstractValidator<DeleteActionParameterDepositorCommand>
{
    public DeleteActionParameterDepositorValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
