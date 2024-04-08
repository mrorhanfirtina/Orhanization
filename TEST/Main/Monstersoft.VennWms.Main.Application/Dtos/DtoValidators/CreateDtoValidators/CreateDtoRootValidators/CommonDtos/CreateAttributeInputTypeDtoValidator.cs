using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.CommonDtos;

public class CreateAttributeInputTypeDtoValidator : AbstractValidator<CreateAttributeInputTypeDto>
{
    public CreateAttributeInputTypeDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
    }
}



