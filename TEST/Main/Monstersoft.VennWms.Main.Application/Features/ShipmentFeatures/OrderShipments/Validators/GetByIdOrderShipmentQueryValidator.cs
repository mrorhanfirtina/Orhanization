using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Validators;

public class GetByIdOrderShipmentQueryValidator : AbstractValidator<GetByIdOrderShipmentQuery>
{
    public GetByIdOrderShipmentQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
