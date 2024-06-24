using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.DtoValidators;

public class CreateProductStockAttributeSubDtoValidator : AbstractValidator<CreateProductStockAttributeSubDto>
{
    public CreateProductStockAttributeSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsNecessary).NotNull().NotEmpty();
    }
}
