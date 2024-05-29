using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.DtoValidators;

public class UpdateReserveReasonDtoValidator : AbstractValidator<UpdateReserveReasonDto>
{
    public UpdateReserveReasonDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsBlocked).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



