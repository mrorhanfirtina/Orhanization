using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.DtoValidators;

public class UpdateActionParameterUserDtoValidator : AbstractValidator<UpdateActionParameterUserDto>
{
    public UpdateActionParameterUserDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull();
        RuleFor(p => p.ActionParameterId).NotEmpty().NotNull();
        RuleFor(p => p.UserId).NotEmpty().NotNull();
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
    }
}
