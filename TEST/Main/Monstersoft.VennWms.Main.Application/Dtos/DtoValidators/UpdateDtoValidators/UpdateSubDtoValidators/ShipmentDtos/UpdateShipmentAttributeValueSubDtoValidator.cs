using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ShipmentDtos;

public class UpdateShipmentAttributeValueSubDtoValidator : AbstractValidator<UpdateShipmentAttributeValueSubDto>
{
    public UpdateShipmentAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ShipmentAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


