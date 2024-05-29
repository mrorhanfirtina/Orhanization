using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Validators;

public class CreateLocationProductCategoryValidator : AbstractValidator<CreateLocationProductCategoryCommand>
{
    public CreateLocationProductCategoryValidator()
    {
        RuleFor(x => x.LocationProductCategory).SetValidator(new CreateLocationProductCategoryDtoValidator());
    }
}

