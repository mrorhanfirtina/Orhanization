using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.DtoValidators;

public class UpdateShipmentAttributeValueSubDtoValidator : AbstractValidator<UpdateShipmentAttributeValueSubDto>
{
    public UpdateShipmentAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ShipmentAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


