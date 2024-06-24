using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Validators;

public class GetByIdProductQueryValidator : AbstractValidator<GetByIdProductQuery>
{
    public GetByIdProductQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
