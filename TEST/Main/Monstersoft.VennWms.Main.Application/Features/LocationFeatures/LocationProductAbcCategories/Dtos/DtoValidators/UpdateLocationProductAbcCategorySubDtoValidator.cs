using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.DtoValidators;

public class UpdateLocationProductAbcCategorySubDtoValidator : AbstractValidator<UpdateLocationProductAbcCategorySubDto>
{
    public UpdateLocationProductAbcCategorySubDtoValidator()
    {
        RuleFor(p => p.AbcCategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
