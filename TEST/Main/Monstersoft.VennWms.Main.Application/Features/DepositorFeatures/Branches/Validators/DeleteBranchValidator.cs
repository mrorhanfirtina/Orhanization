using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Validators;

public class DeleteBranchValidator : AbstractValidator<DeleteBranchCommand>
{
    public DeleteBranchValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
