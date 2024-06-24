using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Validators;

public class CreateProductValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.Product).SetValidator(new CreateProductDtoValidator());
    }
}
