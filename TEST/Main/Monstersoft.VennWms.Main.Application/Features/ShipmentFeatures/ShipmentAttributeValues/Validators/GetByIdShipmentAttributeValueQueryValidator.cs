using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Validators;

public class GetByIdShipmentAttributeValueQueryValidator : AbstractValidator<GetByIdShipmentAttributeValueQuery>
{
    public GetByIdShipmentAttributeValueQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
