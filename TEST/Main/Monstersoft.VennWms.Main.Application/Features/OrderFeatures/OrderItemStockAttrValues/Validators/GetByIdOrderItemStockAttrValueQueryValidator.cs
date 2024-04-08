using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Validators;

public class GetByIdOrderItemStockAttrValueQueryValidator : AbstractValidator<GetByIdOrderItemStockAttrValueQuery>
{
    public GetByIdOrderItemStockAttrValueQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
