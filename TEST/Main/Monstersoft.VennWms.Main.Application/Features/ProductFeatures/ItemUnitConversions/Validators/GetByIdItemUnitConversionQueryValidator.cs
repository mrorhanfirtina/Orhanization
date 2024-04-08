using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Validators;

public class GetByIdItemUnitConversionQueryValidator : AbstractValidator<GetByIdItemUnitConversionQuery>
{
    public GetByIdItemUnitConversionQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
