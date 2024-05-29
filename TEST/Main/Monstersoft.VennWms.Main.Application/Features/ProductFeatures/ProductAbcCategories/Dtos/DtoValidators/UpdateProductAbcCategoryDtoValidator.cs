using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.DtoValidators;

public class UpdateProductAbcCategoryDtoValidator : AbstractValidator<UpdateProductAbcCategoryDto>
{
    public UpdateProductAbcCategoryDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.AbcCategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}







