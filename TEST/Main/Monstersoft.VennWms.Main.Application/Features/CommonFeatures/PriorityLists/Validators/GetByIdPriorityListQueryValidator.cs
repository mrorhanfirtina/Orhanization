using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Validators;

public class GetByIdPriorityListQueryValidator : AbstractValidator<GetByIdPriorityListQuery>
{
    public GetByIdPriorityListQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(1, int.MaxValue);
    }
}



