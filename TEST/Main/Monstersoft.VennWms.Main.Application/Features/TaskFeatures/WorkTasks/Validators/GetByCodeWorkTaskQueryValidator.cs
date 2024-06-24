using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Validators;

public class GetByCodeWorkTaskQueryValidator : AbstractValidator<GetByCodeWorkTaskQuery>
{
    public GetByCodeWorkTaskQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

