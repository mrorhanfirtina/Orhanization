using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LocationDtos;

public class CreateLocationPickingTypeSubDtoValidator : AbstractValidator<CreateLocationPickingTypeSubDto>
{
    public CreateLocationPickingTypeSubDtoValidator()
    {
        RuleFor(p => p.PickingTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
