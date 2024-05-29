using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Validators;

public class CreateSiteDepositorValidator : AbstractValidator<CreateSiteDepositorCommand>
{
    public CreateSiteDepositorValidator()
    {
        RuleFor(x => x.SiteDepositor).SetValidator(new CreateSiteDepositorDtoValidator());
    }
}

