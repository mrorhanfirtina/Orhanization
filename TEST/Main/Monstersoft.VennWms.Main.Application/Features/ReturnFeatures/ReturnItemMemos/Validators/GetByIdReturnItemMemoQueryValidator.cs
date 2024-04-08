using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Validators;

public class GetByIdReturnItemMemoQueryValidator : AbstractValidator<GetByIdReturnItemMemoQuery>
{
    public GetByIdReturnItemMemoQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
