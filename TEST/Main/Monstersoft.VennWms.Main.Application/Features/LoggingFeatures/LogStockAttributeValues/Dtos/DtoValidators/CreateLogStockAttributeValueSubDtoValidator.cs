using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.DtoValidators;

public class CreateLogStockAttributeValueSubDtoValidator : AbstractValidator<CreateLogStockAttributeValueSubDto>
{
    public CreateLogStockAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromValue)
            .Null().NotEmpty().When(p => !string.IsNullOrEmpty(p.FromValue))
            .MaximumLength(60).WithMessage("{PropertyName} alanı null olabilir veya 60 karakterden uzun olamaz.");

        RuleFor(p => p.ToValue)
            .Null().NotEmpty().When(p => !string.IsNullOrEmpty(p.ToValue))
            .MaximumLength(60).WithMessage("{PropertyName} alanı null olabilir veya 60 karakterden uzun olamaz.");
    }
}


