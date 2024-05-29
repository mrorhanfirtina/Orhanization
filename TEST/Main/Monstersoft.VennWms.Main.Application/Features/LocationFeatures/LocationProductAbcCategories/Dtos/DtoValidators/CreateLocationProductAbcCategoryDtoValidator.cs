using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.DtoValidators;

public class CreateLocationProductAbcCategoryDtoValidator : AbstractValidator<CreateLocationProductAbcCategoryDto>
{
    public CreateLocationProductAbcCategoryDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.AbcCategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
