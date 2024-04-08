using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReturnDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ReturnDtos;

public class UpdateReturnAttributeValueSubDtoValidator : AbstractValidator<UpdateReturnAttributeValueSubDto>
{
    public UpdateReturnAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ReturnAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


