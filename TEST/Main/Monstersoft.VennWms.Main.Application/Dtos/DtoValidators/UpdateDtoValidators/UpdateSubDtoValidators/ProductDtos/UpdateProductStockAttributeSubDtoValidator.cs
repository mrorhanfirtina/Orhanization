using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ProductDtos;

public class UpdateProductStockAttributeSubDtoValidator : AbstractValidator<UpdateProductStockAttributeSubDto>
{
    public UpdateProductStockAttributeSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsNecessary).NotNull().NotEmpty();
    }
}
