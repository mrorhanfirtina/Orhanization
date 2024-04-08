using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LocationDtos;

public class UpdateLocationProductAttributeSubDtoValidator : AbstractValidator<UpdateLocationProductAttributeSubDto>
{
    public UpdateLocationProductAttributeSubDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsForbid).NotNull().NotEmpty();
    }
}
