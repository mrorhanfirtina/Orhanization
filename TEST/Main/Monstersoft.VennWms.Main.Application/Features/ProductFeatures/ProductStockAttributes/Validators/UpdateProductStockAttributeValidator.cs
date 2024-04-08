using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Update;





namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Validators;

public class UpdateProductStockAttributeValidator : AbstractValidator<UpdateProductStockAttributeCommand>
{
    public UpdateProductStockAttributeValidator()
    {
        RuleFor(x => x.ProductStockAttribute).SetValidator(new UpdateProductStockAttributeDtoValidator());
    }
}

