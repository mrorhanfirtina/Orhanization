using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Validators;

public class UpdatePoAttributeValidator : AbstractValidator<UpdatePoAttributeCommand>
{
    public UpdatePoAttributeValidator()
    {
        RuleFor(x => x.PoAttribute).SetValidator(new UpdatePoAttributeDtoValidator());
    }
}
