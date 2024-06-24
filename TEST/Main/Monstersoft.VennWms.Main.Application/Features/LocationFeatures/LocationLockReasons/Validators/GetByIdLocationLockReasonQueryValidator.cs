using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Validators;

public class GetByIdLocationLockReasonQueryValidator : AbstractValidator<GetByIdLocationLockReasonQuery>
{
    public GetByIdLocationLockReasonQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


