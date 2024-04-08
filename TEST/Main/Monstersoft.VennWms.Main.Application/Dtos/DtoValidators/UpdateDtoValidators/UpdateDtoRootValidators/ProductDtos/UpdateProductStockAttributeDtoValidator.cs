using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;

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
