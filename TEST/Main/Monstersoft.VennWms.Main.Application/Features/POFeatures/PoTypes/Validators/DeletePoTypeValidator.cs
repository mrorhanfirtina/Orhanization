using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Validators;

public class DeletePoTypeValidator : AbstractValidator<DeletePoTypeCommand>
{
    public DeletePoTypeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
