using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Validators;

public class CreateProductCategoryValidator : AbstractValidator<CreateProductCategoryCommand>
{
    public CreateProductCategoryValidator()
    {
        RuleFor(x => x.ProductCategory).SetValidator(new CreateProductCategoryDtoValidator());
    }
}

