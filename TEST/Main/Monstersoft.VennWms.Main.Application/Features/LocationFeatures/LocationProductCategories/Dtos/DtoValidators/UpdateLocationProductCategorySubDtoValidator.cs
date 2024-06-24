using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.DtoValidators;

public class UpdateLocationProductCategorySubDtoValidator : AbstractValidator<UpdateLocationProductCategorySubDto>
{
    public UpdateLocationProductCategorySubDtoValidator()
    {
        RuleFor(p => p.CategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
