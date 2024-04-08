using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Validators;

public class GetByCodeSupplierQueryValidator : AbstractValidator<GetByCodeSupplierQuery>
{
    public GetByCodeSupplierQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

