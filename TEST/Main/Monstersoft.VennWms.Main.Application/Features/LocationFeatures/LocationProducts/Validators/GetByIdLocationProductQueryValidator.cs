using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Validators;

public class GetByIdLocationProductQueryValidator : AbstractValidator<GetByIdLocationProductQuery>
{
    public GetByIdLocationProductQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
