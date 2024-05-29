using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Validators;

public class UpdateProductAttributeValidator : AbstractValidator<UpdateProductAttributeCommand>
{
    public UpdateProductAttributeValidator()
    {
        RuleFor(x => x.ProductAttribute).SetValidator(new UpdateProductAttributeDtoValidator());
    }
}
