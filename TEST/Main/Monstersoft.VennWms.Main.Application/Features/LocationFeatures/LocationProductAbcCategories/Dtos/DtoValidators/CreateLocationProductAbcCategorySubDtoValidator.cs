using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.DtoValidators;

public class CreateLocationProductAbcCategorySubDtoValidator : AbstractValidator<CreateLocationProductAbcCategorySubDto>
{
    public CreateLocationProductAbcCategorySubDtoValidator()
    {
        RuleFor(p => p.AbcCategoryId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
