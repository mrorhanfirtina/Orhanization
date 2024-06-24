using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Validators;

public class UpdateProductAttributeValueValidator : AbstractValidator<UpdateProductAttributeValueCommand>
{
    public UpdateProductAttributeValueValidator()
    {
        RuleFor(x => x.ProductAttributeValue).SetValidator(new UpdateProductAttributeValueDtoValidator());
    }
}
