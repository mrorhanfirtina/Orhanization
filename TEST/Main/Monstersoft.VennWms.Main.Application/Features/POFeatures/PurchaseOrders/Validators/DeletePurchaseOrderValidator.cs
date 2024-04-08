using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Validators;

public class DeletePurchaseOrderValidator : AbstractValidator<DeletePurchaseOrderCommand>
{
    public DeletePurchaseOrderValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
