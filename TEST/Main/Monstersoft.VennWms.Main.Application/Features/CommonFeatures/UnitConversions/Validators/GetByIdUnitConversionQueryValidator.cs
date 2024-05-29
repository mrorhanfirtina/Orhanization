using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Validators;

public class GetByIdUnitConversionQueryValidator : AbstractValidator<GetByIdUnitConversionQuery>
{
    public GetByIdUnitConversionQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(1, int.MaxValue);
    }
}
