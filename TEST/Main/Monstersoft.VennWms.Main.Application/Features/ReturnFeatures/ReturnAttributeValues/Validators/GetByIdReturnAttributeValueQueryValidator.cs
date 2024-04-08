using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Validators;

public class GetByIdReturnAttributeValueQueryValidator : AbstractValidator<GetByIdReturnAttributeValueQuery>
{
    public GetByIdReturnAttributeValueQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
