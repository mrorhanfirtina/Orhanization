using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Validators;

public class GetByCodeReturnTypeQueryValidator : AbstractValidator<GetByCodeReturnTypeQuery>
{
    public GetByCodeReturnTypeQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

