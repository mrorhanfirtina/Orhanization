using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Validators;

public class UpdateLocationProductAbcCategoryValidator : AbstractValidator<UpdateLocationProductAbcCategoryCommand>
{
    public UpdateLocationProductAbcCategoryValidator()
    {
        RuleFor(x => x.LocationProductAbcCategory).SetValidator(new UpdateLocationProductAbcCategoryDtoValidator());
    }
}

