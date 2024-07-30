using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Validators;

public class UpdateActionParameterCategoryValidator : AbstractValidator<UpdateActionParameterCategoryCommand>
{
    public UpdateActionParameterCategoryValidator()
    {
        RuleFor(x => x.ActionParameterCategory).SetValidator(new UpdateActionParameterCategoryDtoValidator());
    }
}
