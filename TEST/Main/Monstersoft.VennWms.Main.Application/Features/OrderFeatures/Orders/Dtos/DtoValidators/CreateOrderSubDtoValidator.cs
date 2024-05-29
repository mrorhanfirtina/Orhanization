using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.DtoValidators;

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
        RuleFor(x => x.OrderPriority).SetValidator(new CreateOrderPrioritySubDtoValidator());
    }
}


