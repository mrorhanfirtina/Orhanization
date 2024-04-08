using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Validators;

public class GetByIdSiteQueryValidator : AbstractValidator<GetByIdSiteQuery>
{
    public GetByIdSiteQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
