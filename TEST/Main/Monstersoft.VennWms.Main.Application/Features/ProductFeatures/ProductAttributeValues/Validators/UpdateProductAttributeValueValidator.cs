using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Validators;

public class UpdateProductAttributeValueValidator : AbstractValidator<UpdateProductAttributeValueCommand>
{
    public UpdateProductAttributeValueValidator()
    {
        RuleFor(x => x.ProductAttributeValue).SetValidator(new UpdateProductAttributeValueDtoValidator());
    }
}
