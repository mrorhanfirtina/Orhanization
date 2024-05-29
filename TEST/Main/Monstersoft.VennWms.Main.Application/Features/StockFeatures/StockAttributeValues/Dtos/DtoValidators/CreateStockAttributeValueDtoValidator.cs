using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.DtoValidators;

public class CreateStockAttributeValueDtoValidator : AbstractValidator<CreateStockAttributeValueDto>
{
    public CreateStockAttributeValueDtoValidator()
    {
        RuleFor(p => p.StockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}



