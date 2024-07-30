using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.DtoValidators;

public class CreateActionParameterCategoryDtoValidator : AbstractValidator<CreateActionParameterCategoryDto>
{
    public CreateActionParameterCategoryDtoValidator()
    {
        RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(60);
    }
}
