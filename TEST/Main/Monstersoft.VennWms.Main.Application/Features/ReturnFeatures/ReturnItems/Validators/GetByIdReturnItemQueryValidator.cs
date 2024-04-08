using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Validators;

public class GetByIdReturnItemQueryValidator : AbstractValidator<GetByIdReturnItemQuery>
{
    public GetByIdReturnItemQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
