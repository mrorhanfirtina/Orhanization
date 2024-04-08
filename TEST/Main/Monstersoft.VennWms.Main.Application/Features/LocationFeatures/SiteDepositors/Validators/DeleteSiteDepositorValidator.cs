using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Validators;

public class DeleteSiteDepositorValidator : AbstractValidator<DeleteSiteDepositorCommand>
{
    public DeleteSiteDepositorValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

