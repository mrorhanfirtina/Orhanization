using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Validators;

public class GetByIdWorkTaskQueryValidator : AbstractValidator<GetByIdWorkTaskQuery>
{
    public GetByIdWorkTaskQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
