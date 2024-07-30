using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Validators;

public class GetByIdActionParameterCategoryValidator : AbstractValidator<GetByIdActionParameterCategoryQuery>
{
    public GetByIdActionParameterCategoryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
