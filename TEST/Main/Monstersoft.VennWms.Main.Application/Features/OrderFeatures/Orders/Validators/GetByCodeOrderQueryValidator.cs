using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Validators;

public class GetByCodeOrderQueryValidator : AbstractValidator<GetByCodeOrderQuery>
{
    public GetByCodeOrderQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

