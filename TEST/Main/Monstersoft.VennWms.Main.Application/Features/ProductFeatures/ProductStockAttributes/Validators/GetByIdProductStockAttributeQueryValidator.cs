using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Queries.GetById;





namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Validators;

public class GetByIdProductStockAttributeQueryValidator : AbstractValidator<GetByIdProductStockAttributeQuery>
{
    public GetByIdProductStockAttributeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

