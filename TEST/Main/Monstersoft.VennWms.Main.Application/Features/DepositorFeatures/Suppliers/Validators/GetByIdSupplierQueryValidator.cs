using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Validators;

public class GetByIdSupplierQueryValidator : AbstractValidator<GetByIdSupplierQuery>
{
    public GetByIdSupplierQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
