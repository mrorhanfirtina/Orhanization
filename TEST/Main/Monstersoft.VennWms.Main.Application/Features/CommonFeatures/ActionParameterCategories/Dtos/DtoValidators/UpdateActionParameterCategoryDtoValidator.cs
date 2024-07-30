using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.DtoValidators;

public class UpdateActionParameterCategoryDtoValidator : AbstractValidator<UpdateActionParameterCategoryDto>
{
    public UpdateActionParameterCategoryDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull();
        RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(60);
    }
}
