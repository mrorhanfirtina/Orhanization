using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.DtoValidators;

public class CreateLocationLockReasonSubDtoValidator : AbstractValidator<CreateLocationLockReasonSubDto>
{
    public CreateLocationLockReasonSubDtoValidator()
    {
        RuleFor(p => p.LockReasonId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
