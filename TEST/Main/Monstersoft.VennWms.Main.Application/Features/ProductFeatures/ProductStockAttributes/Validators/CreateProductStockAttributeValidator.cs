using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Create;





namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Validators;

public class CreateProductStockAttributeValidator : AbstractValidator<CreateProductStockAttributeCommand>
{
    public CreateProductStockAttributeValidator()
    {
        RuleFor(x => x.ProductStockAttribute).SetValidator(new CreateProductStockAttributeDtoValidator());
    }
}

