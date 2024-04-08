using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ShipmentDtos;

public class UpdateOrderShipItemTaskSubDtoValidator : AbstractValidator<UpdateOrderShipItemTaskSubDto>
{
    public UpdateOrderShipItemTaskSubDtoValidator()
    {
        RuleFor(p => p.WorkTaskId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(x => x.OrderShipItem).SetValidator(new UpdateOrderShipItemSubDtoValidator());
        RuleForEach(x => x.OrderShipItemStocks).SetValidator(new UpdateOrderShipItemStockSubDtoValidator());
    }
}


