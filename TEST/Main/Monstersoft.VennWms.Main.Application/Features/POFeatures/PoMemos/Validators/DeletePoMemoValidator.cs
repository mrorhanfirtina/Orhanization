using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Validators;

public class DeletePoMemoValidator : AbstractValidator<DeletePoMemoCommand>
{
    public DeletePoMemoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
