using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Validators;

public class UpdateLocationProductCategoryValidator : AbstractValidator<UpdateLocationProductCategoryCommand>
{
    public UpdateLocationProductCategoryValidator()
    {
        RuleFor(x => x.LocationProductCategory).SetValidator(new UpdateLocationProductCategoryDtoValidator());
    }
}

