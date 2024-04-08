using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Validators;

public class DeleteUserDepositorValidator : AbstractValidator<DeleteUserDepositorCommand>
{
    public DeleteUserDepositorValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
