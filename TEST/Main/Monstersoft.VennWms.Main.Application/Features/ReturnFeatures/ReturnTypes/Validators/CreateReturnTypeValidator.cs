using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Validators;

public class CreateReturnTypeValidator : AbstractValidator<CreateReturnTypeCommand>
{
    public CreateReturnTypeValidator()
    {
        RuleFor(x => x.ReturnType).SetValidator(new CreateReturnTypeDtoValidator());
    }
}
