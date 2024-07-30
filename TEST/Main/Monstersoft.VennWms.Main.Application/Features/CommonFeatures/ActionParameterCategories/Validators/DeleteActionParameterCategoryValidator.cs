using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Validators;

public class DeleteActionParameterCategoryValidator : AbstractValidator<DeleteActionParameterCategoryCommand>
{
    public DeleteActionParameterCategoryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
