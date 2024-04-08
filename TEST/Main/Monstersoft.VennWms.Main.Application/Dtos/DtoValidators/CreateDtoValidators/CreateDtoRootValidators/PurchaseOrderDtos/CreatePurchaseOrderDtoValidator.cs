using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.PurchaseOrderDtos;

public class CreatePurchaseOrderDtoValidator : AbstractValidator<CreatePurchaseOrderDto>
{
    public CreatePurchaseOrderDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.SupplierId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.PoTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StatusId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(x => x.Supplier).SetValidator(new CreateSupplierSubDtoValidator());
        RuleForEach(x => x.PoAttributeValues).SetValidator(new CreatePoAttributeValueSubDtoValidator());
        RuleForEach(x => x.PoMemo).SetValidator(new CreatePoMemoSubDtoValidator());
        RuleForEach(x => x.Receipt).SetValidator(new CreateReceiptSubDtoValidator());
    }
}



