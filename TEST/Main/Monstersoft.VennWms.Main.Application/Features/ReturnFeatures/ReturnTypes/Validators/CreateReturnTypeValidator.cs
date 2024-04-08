using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Validators;

public class CreateReturnTypeValidator : AbstractValidator<CreateReturnTypeCommand>
{
    public CreateReturnTypeValidator()
    {
        RuleFor(x => x.ReturnType).SetValidator(new CreateReturnTypeDtoValidator());
    }
}
