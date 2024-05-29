using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Validators;

public class CreatePurchaseOrderValidator : AbstractValidator<CreatePurchaseOrderCommand>
{
    public CreatePurchaseOrderValidator()
    {
        RuleFor(x => x.PurchaseOrder).SetValidator(new CreatePurchaseOrderDtoValidator());
    }
}
