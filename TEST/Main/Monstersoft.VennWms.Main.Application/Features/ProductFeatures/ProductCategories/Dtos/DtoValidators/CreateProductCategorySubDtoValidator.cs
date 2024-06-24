using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.DtoValidators;

public class CreateProductCategorySubDtoValidator : AbstractValidator<CreateProductCategorySubDto>
{
    public CreateProductCategorySubDtoValidator()
    {
        RuleFor(p => p.CategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
