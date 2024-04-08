using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Validators;

public class DeleteUnsuitReasonValidator : AbstractValidator<DeleteUnsuitReasonCommand>
{
    public DeleteUnsuitReasonValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
