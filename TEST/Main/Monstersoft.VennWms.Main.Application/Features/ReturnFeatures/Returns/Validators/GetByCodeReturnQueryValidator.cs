using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Validators;

public class GetByCodeReturnQueryValidator : AbstractValidator<GetByCodeReturnQuery>
{
    public GetByCodeReturnQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

