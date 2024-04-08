using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoAggregateValidators.OrderDtos;

public class UpdateOrderItemStockAttrValueSubDtoValidator : AbstractValidator<UpdateOrderItemStockAttrValueSubDto>
{
    public UpdateOrderItemStockAttrValueSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


