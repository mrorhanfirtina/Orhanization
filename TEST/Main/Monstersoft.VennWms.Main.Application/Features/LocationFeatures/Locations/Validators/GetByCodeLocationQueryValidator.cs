using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Validators;

public class GetByCodeLocationQueryValidator : AbstractValidator<GetByCodeLocationQuery>
{
    public GetByCodeLocationQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

