using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.DtoValidators;





namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Validators;

public class CreateProductStockAttributeValidator : AbstractValidator<CreateProductStockAttributeCommand>
{
    public CreateProductStockAttributeValidator()
    {
        RuleFor(x => x.ProductStockAttribute).SetValidator(new CreateProductStockAttributeDtoValidator());
    }
}

