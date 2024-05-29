using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AttributeInputTypes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AttributeInputTypes.Dtos.DtoValidators;

public class UpdateAttributeInputTypeDtoValidator : AbstractValidator<UpdateAttributeInputTypeDto>
{
    public UpdateAttributeInputTypeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
    }
}



