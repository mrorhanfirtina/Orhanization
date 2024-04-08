using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Validators;

public class GetByIdOrderTypeQueryValidator : AbstractValidator<GetByIdOrderTypeQuery>
{
    public GetByIdOrderTypeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
