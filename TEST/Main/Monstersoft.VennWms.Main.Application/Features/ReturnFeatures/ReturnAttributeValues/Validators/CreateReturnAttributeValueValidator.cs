using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Validators;

public class CreateReturnAttributeValueValidator : AbstractValidator<CreateReturnAttributeValueCommand>
{
    public CreateReturnAttributeValueValidator()
    {
        RuleFor(x => x.ReturnAttributeValue).SetValidator(new CreateReturnAttributeValueDtoValidator());
    }
}
