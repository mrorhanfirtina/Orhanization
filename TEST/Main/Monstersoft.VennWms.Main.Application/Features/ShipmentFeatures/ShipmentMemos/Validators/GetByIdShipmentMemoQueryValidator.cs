using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Validators;

public class GetByIdShipmentMemoQueryValidator : AbstractValidator<GetByIdShipmentMemoQuery>
{
    public GetByIdShipmentMemoQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
