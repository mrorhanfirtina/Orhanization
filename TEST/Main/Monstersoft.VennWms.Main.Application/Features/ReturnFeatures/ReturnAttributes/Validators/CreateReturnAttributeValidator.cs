using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Validators;

public class CreateReturnAttributeValidator : AbstractValidator<CreateReturnAttributeCommand>
{
    public CreateReturnAttributeValidator()
    {
        RuleFor(x => x.ReturnAttribute).SetValidator(new CreateReturnAttributeDtoValidator());
    }
}
