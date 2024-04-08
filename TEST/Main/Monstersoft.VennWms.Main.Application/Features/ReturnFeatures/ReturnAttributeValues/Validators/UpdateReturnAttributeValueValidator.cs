using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Validators;

public class UpdateReturnAttributeValueValidator : AbstractValidator<UpdateReturnAttributeValueCommand>
{
    public UpdateReturnAttributeValueValidator()
    {
        RuleFor(x => x.ReturnAttributeValue).SetValidator(new UpdateReturnAttributeValueDtoValidator());
    }
}
