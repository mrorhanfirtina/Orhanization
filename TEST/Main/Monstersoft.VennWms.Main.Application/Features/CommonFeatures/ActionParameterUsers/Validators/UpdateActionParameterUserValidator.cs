using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Validators;

public class UpdateActionParameterUserValidator : AbstractValidator<UpdateActionParameterUserCommand>
{
    public UpdateActionParameterUserValidator()
    {
        RuleFor(x => x.ActionParameterUser).SetValidator(new UpdateActionParameterUserDtoValidator());
    }
}
