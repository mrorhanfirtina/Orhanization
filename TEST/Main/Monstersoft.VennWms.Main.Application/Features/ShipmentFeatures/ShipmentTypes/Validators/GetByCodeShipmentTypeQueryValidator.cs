using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Validators;

public class GetByCodeShipmentTypeQueryValidator : AbstractValidator<GetByCodeShipmentTypeQuery>
{
    public GetByCodeShipmentTypeQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

