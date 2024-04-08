using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Validators;

public class GetByCodeCompanyQueryValidator : AbstractValidator<GetByCodeCompanyQuery>
{
    public GetByCodeCompanyQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

