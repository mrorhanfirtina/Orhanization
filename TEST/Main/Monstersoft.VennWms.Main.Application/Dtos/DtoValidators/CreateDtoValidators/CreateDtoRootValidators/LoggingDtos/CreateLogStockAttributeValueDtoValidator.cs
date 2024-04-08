using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LoggingDtos;

public class CreateLogStockAttributeValueDtoValidator : AbstractValidator<CreateLogStockAttributeValueDto>
{
    public CreateLogStockAttributeValueDtoValidator()
    {
        RuleFor(p => p.LogStockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromValue).MaximumLength(60);
        RuleFor(p => p.ToValue).MaximumLength(60);
    }
}



