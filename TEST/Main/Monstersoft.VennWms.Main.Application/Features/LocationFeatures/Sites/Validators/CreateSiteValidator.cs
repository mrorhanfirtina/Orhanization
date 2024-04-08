using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Validators;

public class CreateSiteValidator : AbstractValidator<CreateSiteCommand>
{
    public CreateSiteValidator()
    {
        RuleFor(x => x.Site).SetValidator(new CreateSiteDtoValidator());
    }
}
