using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.PurchaseOrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.PurchaseOrderDtos;

public class UpdatePurchaseOrderSubDtoValidator : AbstractValidator<UpdatePurchaseOrderSubDto>
{
    public UpdatePurchaseOrderSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.SupplierId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.Supplier).SetValidator(new UpdateSupplierSubDtoValidator());
        RuleForEach(x => x.PoAttributeValues).SetValidator(new UpdatePoAttributeValueSubDtoValidator());
        RuleForEach(x => x.PoMemo).SetValidator(new UpdatePoMemoSubDtoValidator());
        RuleForEach(x => x.Receipt).SetValidator(new UpdateReceiptSubDtoValidator());

    }
}


