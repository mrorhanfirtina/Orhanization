using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Validators;

public class GetByIdLocationStockAttributeQueryValidator : AbstractValidator<GetByIdLocationStockAttributeQuery>
{
    public GetByIdLocationStockAttributeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
