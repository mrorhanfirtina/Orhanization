using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.DtoValidators;

public class UpdateProductAbcCategorySubDtoValidator : AbstractValidator<UpdateProductAbcCategorySubDto>
{
    public UpdateProductAbcCategorySubDtoValidator()
    {
        RuleFor(p => p.AbcCategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
