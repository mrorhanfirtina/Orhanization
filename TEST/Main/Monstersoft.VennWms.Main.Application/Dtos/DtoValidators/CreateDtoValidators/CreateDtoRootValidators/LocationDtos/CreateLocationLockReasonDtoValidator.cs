using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;

public class CreateLocationLockReasonDtoValidator : AbstractValidator<CreateLocationLockReasonDto>
{
    public CreateLocationLockReasonDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.LockReasonId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
