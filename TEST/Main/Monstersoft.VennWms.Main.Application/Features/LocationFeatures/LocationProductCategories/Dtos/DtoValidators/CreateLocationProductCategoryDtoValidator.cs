using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.DtoValidators;

public class CreateLocationProductCategoryDtoValidator : AbstractValidator<CreateLocationProductCategoryDto>
{
    public CreateLocationProductCategoryDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.CategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
