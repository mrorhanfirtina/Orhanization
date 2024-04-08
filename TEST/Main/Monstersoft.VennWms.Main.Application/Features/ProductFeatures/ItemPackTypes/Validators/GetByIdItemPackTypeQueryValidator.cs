using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Validators;

public class GetByIdItemPackTypeQueryValidator : AbstractValidator<GetByIdItemPackTypeQuery>
{
    public GetByIdItemPackTypeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
