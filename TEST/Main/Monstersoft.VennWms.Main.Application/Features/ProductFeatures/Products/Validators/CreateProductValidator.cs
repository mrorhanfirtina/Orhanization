using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Validators;

public class CreateProductValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.Product).SetValidator(new CreateProductDtoValidator());
    }
}
