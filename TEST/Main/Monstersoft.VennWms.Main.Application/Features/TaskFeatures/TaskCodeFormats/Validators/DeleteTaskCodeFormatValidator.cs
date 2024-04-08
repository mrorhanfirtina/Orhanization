using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Validators;

public class DeleteTaskCodeFormatValidator : AbstractValidator<DeleteTaskCodeFormatCommand>
{
    public DeleteTaskCodeFormatValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
