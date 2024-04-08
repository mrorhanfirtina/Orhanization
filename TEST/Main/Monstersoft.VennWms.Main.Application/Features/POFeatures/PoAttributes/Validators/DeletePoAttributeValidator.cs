using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Validators;

public class DeletePoAttributeValidator : AbstractValidator<DeletePoAttributeCommand>
{
    public DeletePoAttributeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
