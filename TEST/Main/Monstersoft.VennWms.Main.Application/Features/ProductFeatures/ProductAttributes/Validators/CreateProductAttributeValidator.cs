using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Validators;

public class CreateProductAttributeValidator : AbstractValidator<CreateProductAttributeCommand>
{
    public CreateProductAttributeValidator()
    {
        RuleFor(x => x.ProductAttribute).SetValidator(new CreateProductAttributeDtoValidator());
    }
}
