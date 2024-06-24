using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Validators;

public class GetByIdReturnQueryValidator : AbstractValidator<GetByIdReturnQuery>
{
    public GetByIdReturnQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
