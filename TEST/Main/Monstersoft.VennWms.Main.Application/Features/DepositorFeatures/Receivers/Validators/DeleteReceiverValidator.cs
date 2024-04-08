using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Validators;

public class DeleteReceiverValidator : AbstractValidator<DeleteReceiverCommand>
{
    public DeleteReceiverValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
