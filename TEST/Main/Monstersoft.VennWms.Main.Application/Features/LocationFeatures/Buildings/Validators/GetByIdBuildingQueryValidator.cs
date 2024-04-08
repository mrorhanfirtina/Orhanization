using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Validators;

public class GetByIdBuildingQueryValidator : AbstractValidator<GetByIdBuildingQuery>
{
    public GetByIdBuildingQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
