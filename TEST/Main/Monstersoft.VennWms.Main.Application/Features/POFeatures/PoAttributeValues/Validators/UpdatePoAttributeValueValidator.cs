using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Validators;

public class UpdatePoAttributeValueValidator : AbstractValidator<UpdatePoAttributeValueCommand>
{
    public UpdatePoAttributeValueValidator()
    {
        RuleFor(x => x.PoAttributeValue).SetValidator(new UpdatePoAttributeValueDtoValidator());
    }
}
