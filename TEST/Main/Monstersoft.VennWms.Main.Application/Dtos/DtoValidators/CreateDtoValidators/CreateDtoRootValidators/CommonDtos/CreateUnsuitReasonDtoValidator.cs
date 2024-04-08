using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.CommonDtos;

public class CreateUnsuitReasonDtoValidator : AbstractValidator<CreateUnsuitReasonDto>
{
    public CreateUnsuitReasonDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsBlocked).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



