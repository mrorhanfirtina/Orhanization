using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Validators;

public class GetByIdCompanyQueryValidator : AbstractValidator<GetByIdCompanyQuery>
{
    public GetByIdCompanyQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
