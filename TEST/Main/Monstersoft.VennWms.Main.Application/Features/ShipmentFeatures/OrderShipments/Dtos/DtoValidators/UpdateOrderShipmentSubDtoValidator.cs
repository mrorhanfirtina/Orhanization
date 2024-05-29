using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.DtoValidators;

public class UpdateOrderShipmentSubDtoValidator : AbstractValidator<UpdateOrderShipmentSubDto>
{
    public UpdateOrderShipmentSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.ShipmentId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProgressStatusId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
