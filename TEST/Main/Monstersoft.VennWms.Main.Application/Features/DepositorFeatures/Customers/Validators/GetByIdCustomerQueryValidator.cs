using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Validators;

public class GetByIdCustomerQueryValidator : AbstractValidator<GetByIdCustomerQuery>
{
    public GetByIdCustomerQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
