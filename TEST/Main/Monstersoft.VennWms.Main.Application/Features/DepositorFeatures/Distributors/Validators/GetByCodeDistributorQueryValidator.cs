using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Validators;

public class GetByCodeDistributorQueryValidator : AbstractValidator<GetByCodeDistributorQuery>
{
    public GetByCodeDistributorQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

