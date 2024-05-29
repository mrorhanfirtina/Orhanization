using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.DtoValidators;

public class UpdateLockReasonDtoValidator : AbstractValidator<UpdateLockReasonDto>
{
    public UpdateLockReasonDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(x => x.Code).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(60);
    }
}
