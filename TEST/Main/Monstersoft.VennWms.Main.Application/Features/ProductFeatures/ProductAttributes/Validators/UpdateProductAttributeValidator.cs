using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Validators;

public class UpdateProductAttributeValidator : AbstractValidator<UpdateProductAttributeCommand>
{
    public UpdateProductAttributeValidator()
    {
        RuleFor(x => x.ProductAttribute).SetValidator(new UpdateProductAttributeDtoValidator());
    }
}
