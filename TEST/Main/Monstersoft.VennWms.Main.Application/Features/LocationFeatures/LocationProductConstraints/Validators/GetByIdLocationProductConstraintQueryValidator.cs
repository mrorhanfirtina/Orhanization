using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Validators;

public class GetByIdLocationProductConstraintQueryValidator : AbstractValidator<GetByIdLocationProductConstraintQuery>
{
    public GetByIdLocationProductConstraintQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

