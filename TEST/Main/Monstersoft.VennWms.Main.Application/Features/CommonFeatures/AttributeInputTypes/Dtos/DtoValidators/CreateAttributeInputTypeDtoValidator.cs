using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AttributeInputTypes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AttributeInputTypes.Dtos.DtoValidators;

public class CreateAttributeInputTypeDtoValidator : AbstractValidator<CreateAttributeInputTypeDto>
{
    public CreateAttributeInputTypeDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
    }
}



