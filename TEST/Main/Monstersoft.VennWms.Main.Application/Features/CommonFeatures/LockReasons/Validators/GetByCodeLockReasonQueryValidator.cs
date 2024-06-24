using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Validators;

public class GetByCodeLockReasonQueryValidator : AbstractValidator<GetByCodeLockReasonQuery>
{
    public GetByCodeLockReasonQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}
