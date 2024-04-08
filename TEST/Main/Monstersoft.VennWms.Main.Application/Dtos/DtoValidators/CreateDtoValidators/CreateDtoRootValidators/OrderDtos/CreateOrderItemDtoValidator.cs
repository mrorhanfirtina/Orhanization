using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;

public class CreateOrderItemDtoValidator : AbstractValidator<CreateOrderItemDto>
{
    public CreateOrderItemDtoValidator()
    {
        RuleFor(p => p.OrderId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.OrderItemMemos).SetValidator(new CreateOrderItemMemoSubDtoValidator());
        RuleForEach(x => x.OrderItemStockAttrValues).SetValidator(new CreateOrderItemStockAttrValueSubDtoValidator());
        RuleForEach(x => x.OrderShipItems).SetValidator(new CreateOrderShipItemSubDtoValidator());
    }
}



