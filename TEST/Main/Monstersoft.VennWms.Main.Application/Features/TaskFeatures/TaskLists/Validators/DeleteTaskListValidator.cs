using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Validators;

public class DeleteTaskListValidator : AbstractValidator<DeleteTaskListCommand>
{
    public DeleteTaskListValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
