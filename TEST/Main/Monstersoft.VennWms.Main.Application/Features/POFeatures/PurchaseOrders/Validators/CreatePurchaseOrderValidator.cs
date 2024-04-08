using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Validators;

public class CreatePurchaseOrderValidator : AbstractValidator<CreatePurchaseOrderCommand>
{
    public CreatePurchaseOrderValidator()
    {
        RuleFor(x => x.PurchaseOrder).SetValidator(new CreatePurchaseOrderDtoValidator());
    }
}
