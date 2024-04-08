using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoAggregateValidators.OrderDtos;

public class UpdateOrderItemSubDtoValidator : AbstractValidator<UpdateOrderItemSubDto>
{
    public UpdateOrderItemSubDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.OrderItemMemos).SetValidator(new UpdateOrderItemMemoSubDtoValidator());
        RuleForEach(x => x.OrderItemStockAttrValues).SetValidator(new UpdateOrderItemStockAttrValueSubDtoValidator());
        RuleForEach(x => x.OrderShipItems).SetValidator(new UpdateOrderShipItemSubDtoValidator());
    }
}


