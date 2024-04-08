using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Validators;

public class DeleteWorkTaskValidator : AbstractValidator<DeleteWorkTaskCommand>
{
    public DeleteWorkTaskValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
