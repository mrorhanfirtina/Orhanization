using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Validators;

public class GetByCodePurchaseOrderQueryValidator : AbstractValidator<GetByCodePurchaseOrderQuery>
{
    public GetByCodePurchaseOrderQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

