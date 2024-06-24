using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Validators;

public class GetByCodePriorityListQueryValidator : AbstractValidator<GetByCodePriorityListQuery>
{
    public GetByCodePriorityListQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}



