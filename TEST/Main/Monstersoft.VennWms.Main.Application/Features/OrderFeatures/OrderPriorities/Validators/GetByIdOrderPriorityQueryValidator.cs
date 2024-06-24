using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Validators;

public class GetByIdOrderPriorityQueryValidator : AbstractValidator<GetByIdOrderPriorityQuery>
{
    public GetByIdOrderPriorityQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


