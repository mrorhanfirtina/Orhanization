using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.OrderDtos;

public class CreateOrderSubDtoValidator : AbstractValidator<CreateOrderSubDto>
{
    public CreateOrderSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(p => p.CustomerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiverId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.Customer).SetValidator(new CreateCustomerSubDtoValidator());
        RuleForEach(x => x.OrderAttributeValues).SetValidator(new CreateOrderAttributeValueSubDtoValidator());
        RuleForEach(x => x.OrderItems).SetValidator(new CreateOrderItemSubDtoValidator());
        RuleForEach(x => x.OrderMemos).SetValidator(new CreateOrderMemoSubDtoValidator());

    }
}


