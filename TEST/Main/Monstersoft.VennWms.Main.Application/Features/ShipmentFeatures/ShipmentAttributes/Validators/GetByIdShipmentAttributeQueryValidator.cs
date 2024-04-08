using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Validators;

public class GetByIdShipmentAttributeQueryValidator : AbstractValidator<GetByIdShipmentAttributeQuery>
{
    public GetByIdShipmentAttributeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
