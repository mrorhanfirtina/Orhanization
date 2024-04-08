using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Validators;

public class DeleteSiteValidator : AbstractValidator<DeleteSiteCommand>
{
    public DeleteSiteValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
