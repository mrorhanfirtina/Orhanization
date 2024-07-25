using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Validators;

public class CreateActionParameterCategoryValidator : AbstractValidator<CreateActionParameterCategoryCommand>
{
    public CreateActionParameterCategoryValidator()
    {
        RuleFor(x => x.ActionParameterCategory).SetValidator(new CreateActionParameterCategoryDtoValidator());
    }
}
