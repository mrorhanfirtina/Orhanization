using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Validators;

public class CreateProductAttributeValidator : AbstractValidator<CreateProductAttributeCommand>
{
    public CreateProductAttributeValidator()
    {
        RuleFor(x => x.ProductAttribute).SetValidator(new CreateProductAttributeDtoValidator());
    }
}
