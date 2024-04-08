using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LoggingDtos;

public class UpdateLogStockAttributeValueSubDtoValidator : AbstractValidator<UpdateLogStockAttributeValueSubDto>
{
    public UpdateLogStockAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromValue).MaximumLength(60);
        RuleFor(p => p.ToValue).MaximumLength(60);
    }
}


