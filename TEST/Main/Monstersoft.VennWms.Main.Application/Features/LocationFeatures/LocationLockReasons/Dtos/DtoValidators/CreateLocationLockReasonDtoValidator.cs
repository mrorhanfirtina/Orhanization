using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.DtoValidators;

public class CreateLocationLockReasonDtoValidator : AbstractValidator<CreateLocationLockReasonDto>
{
    public CreateLocationLockReasonDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.LockReasonId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
