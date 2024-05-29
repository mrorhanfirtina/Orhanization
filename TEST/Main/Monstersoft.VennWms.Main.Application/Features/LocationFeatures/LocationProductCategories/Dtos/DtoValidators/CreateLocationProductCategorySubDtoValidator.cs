using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.DtoValidators;

public class CreateLocationProductCategorySubDtoValidator : AbstractValidator<CreateLocationProductCategorySubDto>
{
    public CreateLocationProductCategorySubDtoValidator()
    {
        RuleFor(p => p.CategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
