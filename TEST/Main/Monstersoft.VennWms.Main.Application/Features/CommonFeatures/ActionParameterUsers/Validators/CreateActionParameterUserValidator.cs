using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Validators;

public class CreateActionParameterUserValidator : AbstractValidator<CreateActionParameterUserCommand>
{
    public CreateActionParameterUserValidator()
    {
        RuleFor(x => x.ActionParameterUser).SetValidator(new CreateActionParameterUserDtoValidator());
    }
}
