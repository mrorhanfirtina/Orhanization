using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.DtoValidators;

public class UpdateProductStockAttributeSubDtoValidator : AbstractValidator<UpdateProductStockAttributeSubDto>
{
    public UpdateProductStockAttributeSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsNecessary).NotNull().NotEmpty();
    }
}
