using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Validators;

public class CreateReturnValidator : AbstractValidator<CreateReturnCommand>
{
    public CreateReturnValidator()
    {
        RuleFor(x => x.Return).SetValidator(new CreateReturnDtoValidator());
    }
}
