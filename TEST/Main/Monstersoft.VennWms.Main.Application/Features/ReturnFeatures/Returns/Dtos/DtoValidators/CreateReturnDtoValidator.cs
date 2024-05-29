using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.DtoValidators;

public class CreateReturnDtoValidator : AbstractValidator<CreateReturnDto>
{
    public CreateReturnDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.CustomerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StatusId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(x => x.Customer).SetValidator(new CreateCustomerSubDtoValidator());
        RuleForEach(x => x.ReturnAttributeValues).SetValidator(new CreateReturnAttributeValueSubDtoValidator());
        RuleForEach(x => x.ReturnItems).SetValidator(new CreateReturnItemSubDtoValidator());
        RuleForEach(x => x.ReturnMemos).SetValidator(new CreateReturnMemoSubDtoValidator());
    }
}



