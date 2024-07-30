using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Validators;

public class GetByIdActionParameterValidator : AbstractValidator<GetByIdActionParameterQuery>
{
    public GetByIdActionParameterValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}