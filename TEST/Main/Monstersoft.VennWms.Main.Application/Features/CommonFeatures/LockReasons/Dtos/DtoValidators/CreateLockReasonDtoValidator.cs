using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.DtoValidators;

public class CreateLockReasonDtoValidator : AbstractValidator<CreateLockReasonDto>
{
    public CreateLockReasonDtoValidator()
    {
        RuleFor(x => x.Code).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(60);
    }
}
