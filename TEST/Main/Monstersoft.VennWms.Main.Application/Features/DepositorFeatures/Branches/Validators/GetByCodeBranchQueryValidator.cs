using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Validators;

public class GetByCodeBranchQueryValidator : AbstractValidator<GetByCodeBranchQuery>
{
    public GetByCodeBranchQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

