﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ReceiptDtos;

public class UpdateReceiptSubDtoValidator : AbstractValidator<UpdateReceiptSubDto>
{
    public UpdateReceiptSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(p => p.ReceiptTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.ReceiptType).SetValidator(new UpdateReceiptTypeSubDtoValidator());
        RuleForEach(x => x.ReceiptAttributeValues).SetValidator(new UpdateReceiptAttributeValueSubDtoValidator());
        RuleForEach(x => x.ReceiptItems).SetValidator(new UpdateReceiptItemSubDtoValidator());
        RuleForEach(x => x.ReceiptMemos).SetValidator(new UpdateReceiptMemoSubDtoValidator());
    }
}


