using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoAggregateValidators.OrderDtos;

public class UpdateOrderSubDtoValidator : AbstractValidator<UpdateOrderSubDto>
{
    public UpdateOrderSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(p => p.CustomerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiverId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.Customer).SetValidator(new UpdateCustomerSubDtoValidator());
        RuleForEach(x => x.OrderAttributeValues).SetValidator(new UpdateOrderAttributeValueSubDtoValidator());
        RuleForEach(x => x.OrderItems).SetValidator(new UpdateOrderItemSubDtoValidator());
        RuleForEach(x => x.OrderMemos).SetValidator(new UpdateOrderMemoSubDtoValidator());
    }
}


