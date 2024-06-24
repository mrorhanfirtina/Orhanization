using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Validators;

public class UpdateProductValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductValidator()
    {
        RuleFor(x => x.Product).SetValidator(new UpdateProductDtoValidator());
    }
}
