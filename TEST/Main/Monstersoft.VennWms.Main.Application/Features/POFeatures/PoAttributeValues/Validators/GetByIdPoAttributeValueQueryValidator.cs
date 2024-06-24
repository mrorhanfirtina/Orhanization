using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Validators;

public class GetByIdPoAttributeValueQueryValidator : AbstractValidator<GetByIdPoAttributeValueQuery>
{
    public GetByIdPoAttributeValueQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
