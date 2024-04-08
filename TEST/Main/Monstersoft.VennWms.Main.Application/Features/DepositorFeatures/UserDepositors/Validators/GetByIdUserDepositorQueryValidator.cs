using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Validators;

public class GetByIdUserDepositorQueryValidator : AbstractValidator<GetByIdUserDepositorQuery>
{
    public GetByIdUserDepositorQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
