using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Validators;

public class CreatePoAttributeValidator : AbstractValidator<CreatePoAttributeCommand>
{
    public CreatePoAttributeValidator()
    {
        RuleFor(x => x.PoAttribute).SetValidator(new CreatePoAttributeDtoValidator());
    }
}
