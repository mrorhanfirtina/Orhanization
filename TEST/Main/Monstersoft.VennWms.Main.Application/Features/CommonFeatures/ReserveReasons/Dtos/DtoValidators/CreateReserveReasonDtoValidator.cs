using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.DtoValidators;

public class CreateReserveReasonDtoValidator : AbstractValidator<CreateReserveReasonDto>
{
    public CreateReserveReasonDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsBlocked).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



