using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Validators;

public class GetByIdOrderQueryValidator : AbstractValidator<GetByIdOrderQuery>
{
    public GetByIdOrderQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
