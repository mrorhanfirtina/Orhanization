using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.DtoValidators;

public class CreateActionParameterUserDtoValidator : AbstractValidator<CreateActionParameterUserDto>
{
    public CreateActionParameterUserDtoValidator()
    {
        RuleFor(p => p.ActionParameterId).NotEmpty().NotNull();
        RuleFor(p => p.UserId).NotEmpty().NotNull();
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
    }
}
