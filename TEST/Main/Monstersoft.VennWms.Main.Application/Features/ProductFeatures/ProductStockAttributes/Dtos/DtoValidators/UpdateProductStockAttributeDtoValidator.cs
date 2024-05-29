using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.DtoValidators;

public class UpdateProductStockAttributeDtoValidator : AbstractValidator<UpdateProductStockAttributeDto>
{
    public UpdateProductStockAttributeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockAttributeId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsNecessary).NotEmpty().NotNull();
    }
}
