using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.DtoValidators;

public class CreateProductAbcCategorySubDtoValidator : AbstractValidator<CreateProductAbcCategorySubDto>
{
    public CreateProductAbcCategorySubDtoValidator()
    {
        RuleFor(p => p.AbcCategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
