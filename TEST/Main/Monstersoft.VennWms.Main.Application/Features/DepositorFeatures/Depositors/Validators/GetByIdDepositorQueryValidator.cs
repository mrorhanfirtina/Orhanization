using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Validators;

public class GetByIdDepositorQueryValidator : AbstractValidator<GetByIdDepositorQuery>
{
    public GetByIdDepositorQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
