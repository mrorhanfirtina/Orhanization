using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LoggingDtos;

public class CreateLogStockAttributeValueSubDtoValidator : AbstractValidator<CreateLogStockAttributeValueSubDto>
{
    public CreateLogStockAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromValue).MaximumLength(60);
        RuleFor(p => p.ToValue).MaximumLength(60);
    }
}


