using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Validators;

public class GetByIdActionParameterDepositorValidator : AbstractValidator<GetByIdActionParameterDepositorQuery>
{
    public GetByIdActionParameterDepositorValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
