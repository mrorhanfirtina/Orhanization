using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Validators;

public class UpdateProductCategoryListValidator : AbstractValidator<UpdateProductCategoryListCommand>
{
    public UpdateProductCategoryListValidator()
    {
        RuleFor(x => x.ProductCategoryList).SetValidator(new UpdateProductCategoryListDtoValidator());
    }
}


