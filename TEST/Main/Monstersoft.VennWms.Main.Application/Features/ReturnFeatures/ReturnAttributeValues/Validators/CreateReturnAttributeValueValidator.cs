using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Validators;

public class CreateReturnAttributeValueValidator : AbstractValidator<CreateReturnAttributeValueCommand>
{
    public CreateReturnAttributeValueValidator()
    {
        RuleFor(x => x.ReturnAttributeValue).SetValidator(new CreateReturnAttributeValueDtoValidator());
    }
}
