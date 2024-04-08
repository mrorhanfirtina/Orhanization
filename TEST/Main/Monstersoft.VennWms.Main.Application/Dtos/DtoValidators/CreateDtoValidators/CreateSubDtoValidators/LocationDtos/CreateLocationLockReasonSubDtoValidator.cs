using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LocationDtos;

public class CreateLocationLockReasonSubDtoValidator : AbstractValidator<CreateLocationLockReasonSubDto>
{
    public CreateLocationLockReasonSubDtoValidator()
    {
        RuleFor(p => p.LockReasonId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
