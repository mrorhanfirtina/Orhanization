using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Validators;

public class CreateProductAbcCategoryValidator : AbstractValidator<CreateProductAbcCategoryCommand>
{
    public CreateProductAbcCategoryValidator()
    {
        RuleFor(x => x.ProductAbcCategory).SetValidator(new CreateProductAbcCategoryDtoValidator());
    }
}


