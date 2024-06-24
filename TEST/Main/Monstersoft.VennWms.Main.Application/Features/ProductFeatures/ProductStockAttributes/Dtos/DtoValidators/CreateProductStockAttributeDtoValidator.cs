using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.DtoValidators;

public class CreateProductStockAttributeDtoValidator : AbstractValidator<CreateProductStockAttributeDto>
{
    public CreateProductStockAttributeDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotNull().WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockAttributeId).NotEmpty().NotNull().WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsNecessary).NotEmpty().NotNull();
    }
}

