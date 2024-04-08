using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.PurchaseOrderDtos;

public class CreatePurchaseOrderSubDtoValidator : AbstractValidator<CreatePurchaseOrderSubDto>
{
    public CreatePurchaseOrderSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.SupplierId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.Supplier).SetValidator(new CreateSupplierSubDtoValidator());
        RuleForEach(x => x.PoAttributeValues).SetValidator(new CreatePoAttributeValueSubDtoValidator());
        RuleForEach(x => x.PoMemo).SetValidator(new CreatePoMemoSubDtoValidator());
        RuleForEach(x => x.Receipt).SetValidator(new CreateReceiptSubDtoValidator());

    }
}


