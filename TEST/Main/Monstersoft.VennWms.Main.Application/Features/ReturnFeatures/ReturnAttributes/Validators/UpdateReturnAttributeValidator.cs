using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Validators;

public class UpdateReturnAttributeValidator : AbstractValidator<UpdateReturnAttributeCommand>
{
    public UpdateReturnAttributeValidator()
    {
        RuleFor(x => x.ReturnAttribute).SetValidator(new UpdateReturnAttributeDtoValidator());
    }
}
