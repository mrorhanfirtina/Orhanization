using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Validators;

public class CreateProductCategoryListValidator : AbstractValidator<CreateProductCategoryListCommand>
{
    public CreateProductCategoryListValidator()
    {
        RuleFor(x => x.ProductCategoryList).SetValidator(new CreateProductCategoryListDtoValidator());
    }
}


