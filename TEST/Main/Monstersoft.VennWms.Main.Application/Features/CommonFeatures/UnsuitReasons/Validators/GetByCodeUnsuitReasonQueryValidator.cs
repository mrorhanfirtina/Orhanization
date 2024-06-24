using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Validators;

public class GetByCodeUnsuitReasonQueryValidator : AbstractValidator<GetByCodeUnsuitReasonQuery>
{
    public GetByCodeUnsuitReasonQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

