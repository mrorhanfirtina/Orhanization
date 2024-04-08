using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ProductDtos;

public class CreateProductStockAttributeSubDtoValidator :AbstractValidator<CreateProductStockAttributeSubDto>
{
    public CreateProductStockAttributeSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsNecessary).NotNull().NotEmpty();
    }
}
