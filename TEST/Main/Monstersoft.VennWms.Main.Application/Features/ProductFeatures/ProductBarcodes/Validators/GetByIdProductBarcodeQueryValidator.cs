using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Validators;

public class GetByIdProductBarcodeQueryValidator : AbstractValidator<GetByIdProductBarcodeQuery>
{
    public GetByIdProductBarcodeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
