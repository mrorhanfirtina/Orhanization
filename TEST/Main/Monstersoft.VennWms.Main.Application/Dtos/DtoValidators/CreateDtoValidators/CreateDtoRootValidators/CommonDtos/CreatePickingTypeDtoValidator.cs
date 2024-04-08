using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.CommonDtos;

public class CreatePickingTypeDtoValidator : AbstractValidator<CreatePickingTypeDto>
{
    public CreatePickingTypeDtoValidator()
    {
        RuleFor(x => x.Code).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(60);
    }
}
