using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ReturnDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;

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



