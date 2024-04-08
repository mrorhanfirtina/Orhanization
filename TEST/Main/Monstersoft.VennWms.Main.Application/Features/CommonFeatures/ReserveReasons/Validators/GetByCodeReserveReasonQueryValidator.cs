using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Validators;

public class GetByCodeReserveReasonQueryValidator : AbstractValidator<GetByCodeReserveReasonQuery>
{
    public GetByCodeReserveReasonQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

