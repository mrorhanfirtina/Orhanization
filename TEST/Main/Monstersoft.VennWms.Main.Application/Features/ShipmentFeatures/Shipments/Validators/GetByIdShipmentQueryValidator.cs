using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Validators;

public class GetByIdShipmentQueryValidator : AbstractValidator<GetByIdShipmentQuery>
{
    public GetByIdShipmentQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
