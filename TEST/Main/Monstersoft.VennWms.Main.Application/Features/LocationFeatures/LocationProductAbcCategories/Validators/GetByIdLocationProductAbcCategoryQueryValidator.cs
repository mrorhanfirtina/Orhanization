using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Validators;

public class GetByIdLocationProductAbcCategoryQueryValidator : AbstractValidator<GetByIdLocationProductAbcCategoryQuery>
{
    public GetByIdLocationProductAbcCategoryQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

