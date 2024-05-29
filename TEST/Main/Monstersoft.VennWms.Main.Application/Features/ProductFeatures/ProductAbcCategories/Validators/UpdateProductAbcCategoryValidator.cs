using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Validators;

public class UpdateProductAbcCategoryValidator : AbstractValidator<UpdateProductAbcCategoryCommand>
{
    public UpdateProductAbcCategoryValidator()
    {
        RuleFor(x => x.ProductAbcCategory).SetValidator(new UpdateProductAbcCategoryDtoValidator());
    }
}


