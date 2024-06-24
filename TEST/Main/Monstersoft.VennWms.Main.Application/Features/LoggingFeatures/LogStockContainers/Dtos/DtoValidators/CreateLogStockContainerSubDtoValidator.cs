using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Dtos.DtoValidators;

public class CreateLogStockContainerSubDtoValidator : AbstractValidator<CreateLogStockContainerSubDto>
{
    public CreateLogStockContainerSubDtoValidator()
    {
        RuleFor(p => p.FromContainerId).Null().NotEmpty().When(p => p.FromContainerId != null).NotEqual(Guid.Empty).When(p => p.FromContainerId != null).WithMessage("{PropertyName} alanı null veya boş Guid olabilir veya eklenmelidir.");
        RuleFor(p => p.ToContainerId).Null().NotEmpty().When(p => p.ToContainerId != null).NotEqual(Guid.Empty).When(p => p.ToContainerId != null).WithMessage("{PropertyName} alanı null veya boş Guid olabilir veya eklenmelidir.");
        RuleFor(p => p.FromContainerSSCC).Null().NotEmpty().When(p => !string.IsNullOrEmpty(p.FromContainerSSCC)).MaximumLength(30).WithMessage("{PropertyName} alanı null olabilir veya 30 karakterden uzun olamaz.");
        RuleFor(p => p.ToContainerSSCC).Null().NotEmpty().When(p => !string.IsNullOrEmpty(p.ToContainerSSCC)).MaximumLength(30).WithMessage("{PropertyName} alanı null olabilir veya 30 karakterden uzun olamaz.");
        RuleFor(p => p.FromContainerTypeId).Null().NotEmpty().When(p => p.FromContainerTypeId != null).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.ToContainerTypeId).Null().NotEmpty().When(p => p.ToContainerTypeId != null).InclusiveBetween(0, int.MaxValue);
    }
}


