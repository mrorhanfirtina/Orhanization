using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Validators;

public class UpdateReturnAttributeValueValidator : AbstractValidator<UpdateReturnAttributeValueCommand>
{
    public UpdateReturnAttributeValueValidator()
    {
        RuleFor(x => x.ReturnAttributeValue).SetValidator(new UpdateReturnAttributeValueDtoValidator());
    }
}
