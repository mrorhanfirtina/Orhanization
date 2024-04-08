using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Validators;

public class GetByCodeZoneQueryValidator : AbstractValidator<GetByCodeZoneQuery>
{
    public GetByCodeZoneQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

