using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Validators;

public class GetByIdLocationQueryValidator : AbstractValidator<GetByIdLocationQuery>
{
    public GetByIdLocationQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
