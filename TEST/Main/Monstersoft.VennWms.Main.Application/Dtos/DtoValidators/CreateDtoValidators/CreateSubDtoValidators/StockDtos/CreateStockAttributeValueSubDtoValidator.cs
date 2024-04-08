using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.StockDtos;

public class CreateStockAttributeValueSubDtoValidator : AbstractValidator<CreateStockAttributeValueSubDto>
{
    public CreateStockAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


