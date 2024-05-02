﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;

public class UpdateReturnDtoValidator : AbstractValidator<UpdateReturnDto>
{
    public UpdateReturnDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.CustomerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StatusId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(x => x.Customer).SetValidator(new UpdateCustomerSubDtoValidator());
        RuleForEach(x => x.ReturnAttributeValues).SetValidator(new UpdateReturnAttributeValueSubDtoValidator());
        RuleForEach(x => x.ReturnItems).SetValidator(new UpdateReturnItemSubDtoValidator());
        RuleForEach(x => x.ReturnMemos).SetValidator(new UpdateReturnMemoSubDtoValidator());
    }
}


