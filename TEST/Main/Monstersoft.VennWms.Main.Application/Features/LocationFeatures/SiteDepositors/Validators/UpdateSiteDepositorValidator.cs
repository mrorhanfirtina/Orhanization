using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Validators;

public class UpdateSiteDepositorValidator : AbstractValidator<UpdateSiteDepositorCommand>
{
    public UpdateSiteDepositorValidator()
    {
        RuleFor(x => x.SiteDepositor).SetValidator(new UpdateSiteDepositorDtoValidator());
    }
}

