using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Validators;

public class GetByIdBranchQueryValidator : AbstractValidator<GetByIdBranchQuery>
{
    public GetByIdBranchQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
