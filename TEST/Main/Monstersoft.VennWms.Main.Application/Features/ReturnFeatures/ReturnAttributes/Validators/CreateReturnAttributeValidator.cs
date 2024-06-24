using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Validators;

public class CreateReturnAttributeValidator : AbstractValidator<CreateReturnAttributeCommand>
{
    public CreateReturnAttributeValidator()
    {
        RuleFor(x => x.ReturnAttribute).SetValidator(new CreateReturnAttributeDtoValidator());
    }
}
