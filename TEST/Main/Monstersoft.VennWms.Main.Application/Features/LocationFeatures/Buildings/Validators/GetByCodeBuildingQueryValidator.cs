using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Validators;

public class GetByCodeBuildingQueryValidator : AbstractValidator<GetByCodeBuildingQuery>
{
    public GetByCodeBuildingQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

