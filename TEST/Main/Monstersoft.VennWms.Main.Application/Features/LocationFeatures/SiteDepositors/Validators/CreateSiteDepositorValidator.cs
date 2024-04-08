using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Validators;

public class CreateSiteDepositorValidator : AbstractValidator<CreateSiteDepositorCommand>
{
    public CreateSiteDepositorValidator()
    {
        RuleFor(x => x.SiteDepositor).SetValidator(new CreateSiteDepositorDtoValidator());
    }
}

