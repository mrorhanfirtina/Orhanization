using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Validators;

public class CreateReturnValidator : AbstractValidator<CreateReturnCommand>
{
    public CreateReturnValidator()
    {
        RuleFor(x => x.Return).SetValidator(new CreateReturnDtoValidator());
    }
}
