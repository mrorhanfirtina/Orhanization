using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ShipmentDtos;

public class CreateShipmentAttributeValueSubDtoValidator : AbstractValidator<CreateShipmentAttributeValueSubDto>
{
    public CreateShipmentAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ShipmentAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


