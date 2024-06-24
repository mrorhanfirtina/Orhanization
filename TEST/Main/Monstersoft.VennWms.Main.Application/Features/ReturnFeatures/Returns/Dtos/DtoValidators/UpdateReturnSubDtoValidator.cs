using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.DtoValidators;

public class UpdateReturnSubDtoValidator : AbstractValidator<UpdateReturnSubDto>
{
    public UpdateReturnSubDtoValidator()
    {
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


