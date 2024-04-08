using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Validators;

public class GetByIdOrderShipItemStockQueryValidator : AbstractValidator<GetByIdOrderShipItemStockQuery>
{
    public GetByIdOrderShipItemStockQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
