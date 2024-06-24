using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.DtoValidators;





namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Validators;

public class UpdateProductStockAttributeValidator : AbstractValidator<UpdateProductStockAttributeCommand>
{
    public UpdateProductStockAttributeValidator()
    {
        RuleFor(x => x.ProductStockAttribute).SetValidator(new UpdateProductStockAttributeDtoValidator());
    }
}

