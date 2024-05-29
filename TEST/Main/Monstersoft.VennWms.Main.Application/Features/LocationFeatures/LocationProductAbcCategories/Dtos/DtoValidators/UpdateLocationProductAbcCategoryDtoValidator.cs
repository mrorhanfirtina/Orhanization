using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.DtoValidators;

public class UpdateLocationProductAbcCategoryDtoValidator : AbstractValidator<UpdateLocationProductAbcCategoryDto>
{
    public UpdateLocationProductAbcCategoryDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.LocationId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.AbcCategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}







