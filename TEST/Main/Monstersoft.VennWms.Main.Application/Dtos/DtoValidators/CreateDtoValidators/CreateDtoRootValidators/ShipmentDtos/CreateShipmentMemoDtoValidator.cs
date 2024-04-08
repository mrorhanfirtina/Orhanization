using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ShipmentDtos;

public class CreateShipmentMemoDtoValidator : AbstractValidator<CreateShipmentMemoDto>
{
    public CreateShipmentMemoDtoValidator()
    {
        RuleFor(p => p.ShipmentId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}



