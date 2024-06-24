using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Validators;

public class GetByIdOrderItemQueryValidator : AbstractValidator<GetByIdOrderItemQuery>
{
    public GetByIdOrderItemQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
