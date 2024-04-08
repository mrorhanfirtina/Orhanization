using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Validators;

public class GetByIdUnitQueryValidator : AbstractValidator<GetByIdUnitQuery>
{
    public GetByIdUnitQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
