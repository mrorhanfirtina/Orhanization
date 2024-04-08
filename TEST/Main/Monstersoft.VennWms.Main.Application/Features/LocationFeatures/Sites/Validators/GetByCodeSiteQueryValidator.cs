using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Validators;

public class GetByCodeSiteQueryValidator : AbstractValidator<GetByCodeSiteQuery>
{
    public GetByCodeSiteQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

