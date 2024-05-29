using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Validators;

public class CreateLocationProductAbcCategoryValidator : AbstractValidator<CreateLocationProductAbcCategoryCommand>
{
    public CreateLocationProductAbcCategoryValidator()
    {
        RuleFor(x => x.LocationProductAbcCategory).SetValidator(new CreateLocationProductAbcCategoryDtoValidator());
    }
}

