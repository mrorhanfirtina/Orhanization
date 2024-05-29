using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.DtoValidators;

public class CreateOrderDtoValidator : AbstractValidator<CreateOrderDto>
{
    public CreateOrderDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(p => p.CustomerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiverId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.OrderTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.Customer).SetValidator(new CreateCustomerSubDtoValidator());
        RuleFor(x => x.OrderPriority).SetValidator(new CreateOrderPrioritySubDtoValidator());
        RuleFor(x => x.OrderShipment).SetValidator(new CreateOrderShipmentSubDtoValidator());
        RuleForEach(x => x.OrderAttributeValues).SetValidator(new CreateOrderAttributeValueSubDtoValidator());
        RuleForEach(x => x.OrderItems).SetValidator(new CreateOrderItemSubDtoValidator());
        RuleForEach(x => x.OrderMemos).SetValidator(new CreateOrderMemoSubDtoValidator());
    }
}



