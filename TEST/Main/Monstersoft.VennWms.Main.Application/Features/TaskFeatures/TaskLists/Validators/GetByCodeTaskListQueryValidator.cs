using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Validators;

public class GetByCodeTaskListQueryValidator : AbstractValidator<GetByCodeTaskListQuery>
{
    public GetByCodeTaskListQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

