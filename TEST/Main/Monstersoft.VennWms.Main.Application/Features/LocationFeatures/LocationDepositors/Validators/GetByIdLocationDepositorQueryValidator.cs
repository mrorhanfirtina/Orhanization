using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Validators;

public class GetByIdLocationDepositorQueryValidator : AbstractValidator<GetByIdLocationDepositorQuery>
{
    public GetByIdLocationDepositorQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

