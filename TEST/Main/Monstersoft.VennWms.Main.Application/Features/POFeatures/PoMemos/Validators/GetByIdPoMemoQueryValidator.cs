using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Validators;

public class GetByIdPoMemoQueryValidator : AbstractValidator<GetByIdPoMemoQuery>
{
    public GetByIdPoMemoQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
