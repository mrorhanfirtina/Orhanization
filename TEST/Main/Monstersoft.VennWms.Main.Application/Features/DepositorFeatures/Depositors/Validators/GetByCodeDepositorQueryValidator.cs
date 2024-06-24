using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Validators;

public class GetByCodeDepositorQueryValidator : AbstractValidator<GetByCodeDepositorQuery>
{
    public GetByCodeDepositorQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

