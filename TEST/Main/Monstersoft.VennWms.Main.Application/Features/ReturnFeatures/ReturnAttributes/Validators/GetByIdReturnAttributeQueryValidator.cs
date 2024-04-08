using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Validators;

public class GetByIdReturnAttributeQueryValidator : AbstractValidator<GetByIdReturnAttributeQuery>
{
    public GetByIdReturnAttributeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
