using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Validators;

public class CreatePoAttributeValueValidator : AbstractValidator<CreatePoAttributeValueCommand>
{
    public CreatePoAttributeValueValidator()
    {
        RuleFor(x => x.PoAttributeValue).SetValidator(new CreatePoAttributeValueDtoValidator());
    }
}
