using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.CommonDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.CommonDtos;

public class UpdateAttributeInputTypeDtoValidator : AbstractValidator<UpdateAttributeInputTypeDto>
{
    public UpdateAttributeInputTypeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
    }
}



