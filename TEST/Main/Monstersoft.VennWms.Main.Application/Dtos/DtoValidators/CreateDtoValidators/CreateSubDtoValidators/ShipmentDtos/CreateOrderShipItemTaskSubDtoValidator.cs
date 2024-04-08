using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ShipmentDtos;

public class CreateOrderShipItemTaskSubDtoValidator : AbstractValidator<CreateOrderShipItemTaskSubDto>
{
    public CreateOrderShipItemTaskSubDtoValidator()
    {
        RuleFor(p => p.WorkTaskId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(x => x.OrderShipItem).SetValidator(new CreateOrderShipItemSubDtoValidator());
        RuleForEach(x => x.OrderShipItemStocks).SetValidator(new CreateOrderShipItemStockSubDtoValidator());
    }
}


