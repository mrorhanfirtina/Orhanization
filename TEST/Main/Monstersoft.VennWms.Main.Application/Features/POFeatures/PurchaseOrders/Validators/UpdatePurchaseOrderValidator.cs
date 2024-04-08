using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Validators;

public class UpdatePurchaseOrderValidator : AbstractValidator<UpdatePurchaseOrderCommand>
{
    public UpdatePurchaseOrderValidator()
    {
        RuleFor(x => x.PurchaseOrder).SetValidator(new UpdatePurchaseOrderDtoValidator());
    }
}
