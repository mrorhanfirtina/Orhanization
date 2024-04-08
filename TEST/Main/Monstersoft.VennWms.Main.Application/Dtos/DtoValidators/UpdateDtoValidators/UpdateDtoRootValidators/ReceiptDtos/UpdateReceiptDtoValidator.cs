using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;

public class UpdateReceiptDtoValidator : AbstractValidator<UpdateReceiptDto>
{
    public UpdateReceiptDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(p => p.PurchaseOrderId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StatusId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(x => x.PurchaseOrder).SetValidator(new UpdatePurchaseOrderSubDtoValidator());
        RuleForEach(x => x.ReceiptAttributeValues).SetValidator(new UpdateReceiptAttributeValueSubDtoValidator());
        RuleForEach(x => x.ReceiptItems).SetValidator(new UpdateReceiptItemSubDtoValidator());
        RuleForEach(x => x.ReceiptMemos).SetValidator(new UpdateReceiptMemoSubDtoValidator());
    }
}



