using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.DtoValidators;

public class CreateProductCategoryDtoValidator : AbstractValidator<CreateProductCategoryDto>
{
    public CreateProductCategoryDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.CategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
