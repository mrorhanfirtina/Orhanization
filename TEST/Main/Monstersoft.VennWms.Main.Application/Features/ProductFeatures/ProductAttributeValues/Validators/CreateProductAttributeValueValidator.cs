using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Validators;

public class CreateProductAttributeValueValidator : AbstractValidator<CreateProductAttributeValueCommand>
{
    public CreateProductAttributeValueValidator()
    {
        RuleFor(x => x.ProductAttributeValue).SetValidator(new CreateProductAttributeValueDtoValidator());
    }
}
