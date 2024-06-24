using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.DtoValidators;

public class UpdateLocationProductSubDtoValidator : AbstractValidator<UpdateLocationProductSubDto>
{
    public UpdateLocationProductSubDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsForbid).NotNull().NotEmpty();
    }
}
