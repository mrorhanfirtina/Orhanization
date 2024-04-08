using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ReceiptDtos;

public class CreateReceiptSubDtoValidator : AbstractValidator<CreateReceiptSubDto>
{
    public CreateReceiptSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(p => p.ReceiptTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.ReceiptType).SetValidator(new CreateReceiptTypeSubDtoValidator());
        RuleForEach(x => x.ReceiptAttributeValues).SetValidator(new CreateReceiptAttributeValueSubDtoValidator());
        RuleForEach(x => x.ReceiptItems).SetValidator(new CreateReceiptItemSubDtoValidator());
        RuleForEach(x => x.ReceiptMemos).SetValidator(new CreateReceiptMemoSubDtoValidator());
    }
}


