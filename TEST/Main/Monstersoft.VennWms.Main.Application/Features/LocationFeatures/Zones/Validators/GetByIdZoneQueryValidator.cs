using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Validators;

public class GetByIdZoneQueryValidator : AbstractValidator<GetByIdZoneQuery>
{
    public GetByIdZoneQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
