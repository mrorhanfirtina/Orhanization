using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Validators;

public class GetByIdPoTypeQueryValidator : AbstractValidator<GetByIdPoTypeQuery>
{
    public GetByIdPoTypeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
