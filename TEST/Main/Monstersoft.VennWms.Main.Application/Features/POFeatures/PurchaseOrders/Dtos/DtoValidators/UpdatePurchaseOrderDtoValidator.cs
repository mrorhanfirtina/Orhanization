using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.DtoValidators;

public class UpdatePurchaseOrderDtoValidator : AbstractValidator<UpdatePurchaseOrderDto>
{
    public UpdatePurchaseOrderDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.SupplierId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.PoTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StatusId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(x => x.Supplier).SetValidator(new UpdateSupplierSubDtoValidator());
        RuleForEach(x => x.PoAttributeValues).SetValidator(new UpdatePoAttributeValueSubDtoValidator());
        RuleForEach(x => x.PoMemo).SetValidator(new UpdatePoMemoSubDtoValidator());
        RuleForEach(x => x.Receipt).SetValidator(new UpdateReceiptSubDtoValidator());
    }
}



