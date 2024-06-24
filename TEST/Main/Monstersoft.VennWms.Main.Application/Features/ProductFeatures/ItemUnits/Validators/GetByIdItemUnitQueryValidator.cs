using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Validators;

public class GetByIdItemUnitQueryValidator : AbstractValidator<GetByIdItemUnitQuery>
{
    public GetByIdItemUnitQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
