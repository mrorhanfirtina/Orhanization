using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Validators;

public class GetByCodeDepositorCompanyQueryValidator : AbstractValidator<GetByCodeDepositorCompanyQuery>
{
    public GetByCodeDepositorCompanyQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

