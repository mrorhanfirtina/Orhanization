using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Validators;

public class GetByIdOrderAttributeValueQueryValidator : AbstractValidator<GetByIdOrderAttributeValueQuery>
{
    public GetByIdOrderAttributeValueQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
