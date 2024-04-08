using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Validators;

public class GetByCodeUnitQueryValidator : AbstractValidator<GetByCodeUnitQuery>
{
    public GetByCodeUnitQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

