using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Validators;

public class DeletePoAttributeValueValidator : AbstractValidator<DeletePoAttributeValueCommand>
{
    public DeletePoAttributeValueValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
