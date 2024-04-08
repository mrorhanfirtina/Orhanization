using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;

public class CreateProductStockAttributeDtoValidator : AbstractValidator<CreateProductStockAttributeDto>
{
    public CreateProductStockAttributeDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotNull().WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockAttributeId).NotEmpty().NotNull().WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsNecessary).NotEmpty().NotNull();
    }
}

