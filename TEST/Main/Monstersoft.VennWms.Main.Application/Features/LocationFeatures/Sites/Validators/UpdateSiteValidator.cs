using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Validators;

public class UpdateSiteValidator : AbstractValidator<UpdateSiteCommand>
{
    public UpdateSiteValidator()
    {
        RuleFor(x => x.Site).SetValidator(new UpdateSiteDtoValidator());
    }
}
