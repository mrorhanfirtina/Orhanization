using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Validators;

public class GetByCodeOrderAttributeQueryValidator : AbstractValidator<GetByCodeOrderAttributeQuery>
{
    public GetByCodeOrderAttributeQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

