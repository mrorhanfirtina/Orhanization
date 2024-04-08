using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Validators;

public class GetByIdDistributorQueryValidator : AbstractValidator<GetByIdDistributorQuery>
{
    public GetByIdDistributorQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
