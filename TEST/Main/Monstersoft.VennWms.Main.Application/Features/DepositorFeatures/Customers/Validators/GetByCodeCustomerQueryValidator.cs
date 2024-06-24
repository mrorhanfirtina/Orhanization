using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Validators;

public class GetByCodeCustomerQueryValidator : AbstractValidator<GetByCodeCustomerQuery>
{
    public GetByCodeCustomerQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

