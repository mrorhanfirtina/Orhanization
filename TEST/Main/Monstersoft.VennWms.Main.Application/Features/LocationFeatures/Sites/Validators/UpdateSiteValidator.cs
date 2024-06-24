using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Validators;

public class UpdateSiteValidator : AbstractValidator<UpdateSiteCommand>
{
    public UpdateSiteValidator()
    {
        RuleFor(x => x.Site).SetValidator(new UpdateSiteDtoValidator());
    }
}
