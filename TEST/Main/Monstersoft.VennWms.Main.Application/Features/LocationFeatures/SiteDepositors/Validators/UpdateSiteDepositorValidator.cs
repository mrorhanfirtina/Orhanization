using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Validators;

public class UpdateSiteDepositorValidator : AbstractValidator<UpdateSiteDepositorCommand>
{
    public UpdateSiteDepositorValidator()
    {
        RuleFor(x => x.SiteDepositor).SetValidator(new UpdateSiteDepositorDtoValidator());
    }
}

